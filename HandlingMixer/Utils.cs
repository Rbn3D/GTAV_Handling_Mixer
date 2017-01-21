extern alias NCalc;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using SimpleLogger;
using SimpleLogger.Logging.Handlers;
using System.Diagnostics;
using NCalc::NCalc;

namespace HandlingMixer
{
    public class MathUtils
    {
        public static decimal Lerp(decimal value1, decimal value2, decimal amount)
        {
            return value1 + (value2 - value1) * amount;
        }

        public static decimal DecimalFromString(string value)
        {
            return Decimal.Parse(value, CultureInfo.InvariantCulture.NumberFormat);
        }
    }

    public class DialogUtils
    {
        public static DialogResult ShowMixDoneDialog()
        {
            Form form = new Form();
            Label label = new Label();
            Button showLogBtn = new Button();
            Button buttonOk = new Button();

            form.Text = "Mix Done!";
            label.Text = "Mix done successfully";
            showLogBtn.Text = "Display log";

            showLogBtn.Click += ShowLogBtn_Click;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label.SetBounds(9, 20, 372, 13);
            showLogBtn.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);

            label.AutoSize = true;
            showLogBtn.Anchor = showLogBtn.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, showLogBtn, buttonOk });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            //form.Shown += (sender, e) => Form_Shown(sender, e, tooltipHelp);

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        private static void ShowLogBtn_Click(object sender, EventArgs e)
        {
            LogUtils.displayLog();
        }

        public static DialogResult StringInputBox(string title, string promptText, ref string value, string tooltipHelp = "", InputValidation validation = null)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            if(validation != null)
            {
                form.FormClosing += delegate (object sender, FormClosingEventArgs e) {
                    if (form.DialogResult == DialogResult.OK)
                    {
                        string errorText = validation(textBox.Text);
                        if ((errorText != ""))
                        {
                            e.Cancel = true;
                            MessageBox.Show(form, errorText, "Validation Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox.Focus();
                        }
                    }
                };
            }

            form.Shown += (sender, e) => Form_Shown(sender, e, tooltipHelp);

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static DialogResult EnumInputBox<T>(string title, string promptText, Type enumType, ref T value, string tooltipHelp = "") where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            Form form = new Form();
            Label label = new Label();
            ComboBox enumBox = new ComboBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            enumBox.DataSource = Enum.GetValues(enumType);
            enumBox.SelectedItem = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            enumBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            enumBox.Anchor = enumBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, enumBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.Shown += (sender, e) => Form_Shown(sender, e, tooltipHelp);

            DialogResult dialogResult = form.ShowDialog();

            Enum.TryParse<T>(enumBox.SelectedValue.ToString(), out value);

            return dialogResult;
        }

        public static DialogResult DecimalInputBox(string title, string promptText, ref decimal value, string tooltipHelp = "")
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            textBox.KeyPress += TextBox_KeyPress;

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value.ToString();

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.FormClosing += delegate (object sender, FormClosingEventArgs e) {
                if (form.DialogResult == DialogResult.OK)
                {
                    string errorText = NotEmptyValidation(textBox.Text);
                    if ((errorText != ""))
                    {
                        e.Cancel = true;
                        MessageBox.Show(form, errorText, "Validation Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Focus();
                    }
                }
            };

            form.Shown += (sender, e) => Form_Shown(sender, e, tooltipHelp);

            DialogResult dialogResult = form.ShowDialog();
            value = MathUtils.DecimalFromString(textBox.Text);

            return dialogResult;
        }

        // returns string with float value (allowing empty values)
        public static DialogResult DecimalAsStringInputBox(string title, string promptText,  ref string value, string tooltipHelp = "")
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            textBox.KeyPress += TextBox_KeyPress;

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value.ToString();

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.Shown += (sender, e) => Form_Shown(sender, e, tooltipHelp);

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;

            return dialogResult;
        }

        private static void Form_Shown(object sender, EventArgs e, string tooltipText)
        {
            var tt = new ToolTip();
            tt.ToolTipTitle = "Info";
            tt.ToolTipIcon = ToolTipIcon.Info;
            tt.Show(tooltipText, sender as Form, 8, 139, 200000);
        }

        private static void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, decimal and minus
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

            // only allow one minus sign at the benigning
            if (e.KeyChar == 45 && (sender as TextBox).SelectionStart > 0 || 
                (sender as TextBox).Text.IndexOf(e.KeyChar) != -1)

                e.Handled = true;
        }

        public delegate string InputValidation(string value);

        public static InputValidation NotEmptyValidation = delegate (string val) {
            if (val == "")
                return "Value cannot be empty.";
            return "";
        };

        public static InputValidation ValidCustomFormula = delegate (string val) {
            if (String.IsNullOrWhiteSpace(val))
                return "";
            else
            {
                // dynamic ev = new ExpressionEvaluator(CultureInfo.InvariantCulture);
                var expr = new Expression(val);

                decimal x = 5m;
                decimal a = 6m;
                decimal b = 7m;

                expr.Parameters["x"] = x;
                expr.Parameters["a"] = a;
                expr.Parameters["b"] = b;

                try
                {
                    Func<decimal> f = expr.ToLambda<decimal>();

                    decimal res = f();
                }
                catch(Exception e)
                {
                    return "There was an error while parsing the custom formula: " + e.Message;
                }
                

                return "";
            }
        };

        public static InputValidation ValidDecimalAsString = delegate (string val) {
            if (String.IsNullOrWhiteSpace(val))
                return "";

            decimal f;

            if (!decimal.TryParse(val, out f))
            {
                return "Value must be a valid decimal number or empty";
            }

            return "";
        };
    }

    public class IoUtils
    {
        public static T FromXML<T>(string xml)
        {
            using (StringReader stringReader = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
        }

        public static string ToXML<T>(T obj)
        {
            using (StringWriter stringWriter = new StringWriter(new StringBuilder()))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(stringWriter, obj);
                return stringWriter.ToString();
            }
        }
    }

    public class LogUtils
    {
        public static void initializeLogger()
        {
            Logger.LoggerHandlerManager.AddHandler(new FileLoggerHandler(getLogFilename()));
        }

        public static void displayLog()
        {
            var fInfo = new FileInfo(getLogFilename());
            if(fInfo.Exists)
                Process.Start(getLogFilename());
        }

        private static string getLogFilename()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "HandlingMixerLog.txt");
        }
    }
}
