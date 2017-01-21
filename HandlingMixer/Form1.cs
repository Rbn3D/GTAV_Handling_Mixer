using HandlingMixer;
using HandlingMixer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HandlingMixer.Metadata;
using System.Threading;
using SimpleLogger;

namespace HnadlingMixer
{
    public partial class Form1 : Form
    {
        public string Apath;
        public string Bpath;

        public List<PropData> handlingProperties;
        public BaseHandlingFile baseHandling = BaseHandlingFile.UseA;

        public bool isDatagridDirty = false;

        public Form1()
        {
            // Invariant culture
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            InitializeComponent();

            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            handlingProperties = Metadata.getHandlingProperties();

            datagrid.AutoGenerateColumns = false;

            Propname.ValueType = typeof(String);
            Propname.ReadOnly = true;

            dataType.ValueType = typeof(HandlingDataType);
            //dataType.DataSource = Enum.GetValues(typeof(HandlingDataType));
            dataType.ReadOnly = true;

            mixType.ValueType = typeof(MixType);
            mixType.DataSource = Enum.GetValues(typeof(MixType));
            mixType.ReadOnly = false;

            mixedValue.ValueType = typeof(decimal);
            mixedValue.ReadOnly = false;

            customFormulaCol.ValueType = typeof(String);

            datagrid.DataSource = handlingProperties;

            baseHandlingFileCb.DataSource = Enum.GetValues(typeof(BaseHandlingFile));
            baseHandlingFileCb.DropDownStyle = ComboBoxStyle.DropDownList;
            baseHandlingFileCb.SelectedIndex = 0;

            LogUtils.initializeLogger();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datagrid.Rows[0].Selected = false;
            isDatagridDirty = false;
            datagrid.ShowCellToolTips = false;
        }

        private void btnFileA_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Handling .meta files (*.meta)|*.meta";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                labelA.Text = path;
                Apath = path;
            }
        }

        private void btnFileB_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Handling .meta files (*.meta)|*.meta";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                labelB.Text = path;
                Bpath = path;
            }
        }

        private void MixBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Apath) || String.IsNullOrEmpty(Bpath))
            {
                MessageBox.Show("Please select two different handling.meta files in the A and B slots first.");
            }
            else
            {
                SaveFileDialog saveDlg = new SaveFileDialog();

                saveDlg.Filter = "Handling .meta files (*.meta)|*.meta";
                saveDlg.FileName = "handling.meta";
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    var path = saveDlg.FileName;

                    var mixer = new HandlingXmlMixer(Apath, Bpath, handlingProperties, baseHandling);
                    var resultXml = mixer.generateMixedHandling();

                    File.WriteAllText(path, resultXml);
                    Logger.Log("Mixed handling saved to: " + path);
                    DialogUtils.ShowMixDoneDialog();
                }
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox1.Text))
            {
                datagrid.DataSource = handlingProperties;
            } else
            {
                var filter = textBox1.Text;

                datagrid.DataSource = handlingProperties.Where(p => p.propName.ToLowerInvariant().Contains(filter.ToLowerInvariant())).ToList();
            }
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            var count = datagrid.SelectedRows.Count;

            selectedLabel.Text = String.Format("Selected: {0} rows", count);

            if(count == 0)
            {
                setTypeSelBtn.Enabled = false;
                setValueSelBtn.Enabled = false;
            } else
            {
                setTypeSelBtn.Enabled = true;
                setValueSelBtn.Enabled = true;
            }
        }

        private void setTypeSelBtn_Click(object sender, EventArgs e)
        {
            MixType mixType = MixType.Mix;
            var result = DialogUtils.EnumInputBox<MixType>("Set mix type", "Choose mix type for selected items", typeof(MixType), ref mixType);

            if(result == DialogResult.OK)
            {
                foreach(DataGridViewRow row in datagrid.SelectedRows)
                {
                    row.Cells["mixType"].Value = mixType;
                }
            }
        }

        private void setValueSelBtn_Click(object sender, EventArgs e)
        {
            Point screenPoint = setValueSelBtn.PointToScreen(new Point(setValueSelBtn.Left, setValueSelBtn.Bottom));
            if (screenPoint.Y + setValuesMenu.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                setValuesMenu.Show(setValueSelBtn, new Point(0, -setValuesMenu.Size.Height));
            }
            else
            {
                setValuesMenu.Show(setValueSelBtn, new Point(0, setValueSelBtn.Height));
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void setMixedValue_Click(object sender, EventArgs e)
        {
            decimal mixedValue = 0.5m;
            var result = DialogUtils.DecimalInputBox("Set mixed value", "Choose mix type for selected items", ref mixedValue, Metadata.getHelpStringForColumn(Metadata.MIXEDVAL_COL));

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datagrid.SelectedRows)
                {
                    row.Cells["mixedValue"].Value = mixedValue;
                }
            }
        }

        private void setValueOffsetMenu_Click(object sender, EventArgs e)
        {
            decimal offset = 0.0m;
            var result = DialogUtils.DecimalInputBox("Set offset value", "Set offset value for selected items", ref offset, Metadata.getHelpStringForColumn(Metadata.VALOFFSET_COL));

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datagrid.SelectedRows)
                {
                    row.Cells["valueOffsetCol"].Value = offset;
                }
            }
        }

        private void setMultiplierMenu_Click(object sender, EventArgs e)
        {
            decimal multiplier = 1.0m;
            var result = DialogUtils.DecimalInputBox("Set multiplier value", "Set offset value for selected items", ref multiplier, Metadata.getHelpStringForColumn(Metadata.VALMULT_COL));

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datagrid.SelectedRows)
                {
                    row.Cells["ValueMultiplierCol"].Value = multiplier;
                }
            }
        }

        private void setCustomFormulaMenu_Click(object sender, EventArgs e)
        {
            string customFormula = "";
            var result = DialogUtils.StringInputBox("Set custom formula", "Set custom formula for selected items", ref customFormula, Metadata.getHelpStringForColumn(Metadata.CUSTOMFORM_COL), DialogUtils.ValidCustomFormula);

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datagrid.SelectedRows)
                {
                    row.Cells["customFormulaCol"].Value = customFormula;
                }
            }
        }

        private void setMinimumValueMenu_Click(object sender, EventArgs e)
        {
            string minimum = "";
            var result = DialogUtils.DecimalAsStringInputBox("Set minimum value", "Set minimum for selected items", ref minimum, Metadata.getHelpStringForColumn(Metadata.MINVAL_COL));

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datagrid.SelectedRows)
                {
                    row.Cells["MinimumValueCol"].Value = minimum;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string maximum = "";
            var result = DialogUtils.DecimalAsStringInputBox("Set maximum value", "Set maximum for selected items", ref maximum, Metadata.getHelpStringForColumn(Metadata.MAXVAL_COL));

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datagrid.SelectedRows)
                {
                    row.Cells["MaximumValueCol"].Value = maximum;
                }
            }
        }

        private void loadMixSetupBtn_Click(object sender, EventArgs e)
        {
            // TODO Better XML handling

            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Mix setup .xml files (*.xml)|*.xml";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;

                handlingProperties = IoUtils.FromXML<List<PropData>>(File.ReadAllText(path));
                datagrid.DataSource = handlingProperties;

                isDatagridDirty = false;
            }
        }

        private void saveMixSetupBtn_Click(object sender, EventArgs e)
        {
            // Save XML and set isDatagridDirty to false if successful

            SaveMixSetup();
        }

        private bool SaveMixSetup()
        {
            SaveFileDialog saveDlg = new SaveFileDialog();

            saveDlg.Filter = "Mix setup .xml files (*.xml)|*.xml";
            saveDlg.FileName = "mixSetup.xml";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                var path = saveDlg.FileName;

                var resultXml = IoUtils.ToXML<List<PropData>>(handlingProperties);

                File.WriteAllText(path, resultXml);
                MessageBox.Show("File saved");

                isDatagridDirty = false;

                return true;
            }

            return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isDatagridDirty)
            {
                var result = MessageBox.Show("Mix setup can be saved for later usage. Save changes?", "Changes are not saved.", MessageBoxButtons.YesNoCancel);

                if(result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    e.Cancel = true;
                    
                    if(result == DialogResult.Yes)
                    {
                        if(SaveMixSetup())
                        {
                            e.Cancel = false;
                        }
                    }
                }
            }
        }

        private void datagrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isDatagridDirty = true;
        }

        // Display Info tooltip
        private void datagrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String helpString = getTooltipHelpString(datagrid.CurrentCell);
            var column = datagrid.CurrentCell.OwningColumn;

            var cell = datagrid.CurrentCell;

            int xOffset = 0;
            int yOffset = cell.Size.Height;

            if(column.GetType() == typeof(DataGridViewComboBoxColumn))
            {
                xOffset = cell.Size.Width;
                yOffset = 10;
            }

            var cellDisplayRect = datagrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            helpTooltip.Show(helpString,
                          datagrid,
                          //cellDisplayRect.X + cell.Size.Width / 2,
                          //cellDisplayRect.Y + cell.Size.Height / 2,
                          cellDisplayRect.X + xOffset,
                          cellDisplayRect.Y + yOffset,
                          2000000);
        }

        private string getTooltipHelpString(DataGridViewCell currentCell)
        {
            var owningColumn = currentCell.OwningColumn;

            var key = "";
            if (owningColumn == mixType)
            {
                key = Metadata.MIXTYPE_COL;
            } 
            else if(owningColumn == mixedValue)
            {
                key = Metadata.MIXEDVAL_COL;
            }
            else if (owningColumn == valueOffsetCol)
            {
                key = Metadata.VALOFFSET_COL;
            }
            else if (owningColumn == ValueMultiplierCol)
            {
                key = Metadata.VALMULT_COL;
            }
            else if (owningColumn == customFormulaCol)
            {
                key = Metadata.CUSTOMFORM_COL;
            }
            else if (owningColumn == MinimumValueCol)
            {
                key = Metadata.MINVAL_COL;
            }
            else if (owningColumn == MaximumValueCol)
            {
                key = Metadata.MAXVAL_COL;
            }

            return Metadata.getHelpStringForColumn(key);
        }

        // Hide tooltip
        private void datagrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            HideHelpTooltip();
        }

        private void datagrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            HideHelpTooltip();
        }

        private void datagrid_MouseLeave(object sender, EventArgs e)
        {
            HideHelpTooltip();
        }

        private void HideHelpTooltip()
        {
            if (helpTooltip.Active)
            {
                helpTooltip.Hide(this);
            }
        }

        private void showTooltipsCB_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ShowHelpTooltips = showTooltipsCB.Checked;
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            datagrid.SelectAll();
        }

        private void SelectNoneBtn_Click(object sender, EventArgs e)
        {
            datagrid.ClearSelection();
        }

        private void datagrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var value = e.FormattedValue as String;

            // don't try to validate over empty
            if(String.IsNullOrWhiteSpace(value))
            {
                e.Cancel = false;
                datagrid[e.ColumnIndex, e.RowIndex].ErrorText = null;
                return;
            }

            var col = datagrid[e.ColumnIndex, e.RowIndex].OwningColumn;
            String errorMsg = null;

            if (col == MinimumValueCol || col == MaximumValueCol)
            {
                errorMsg = DialogUtils.ValidDecimalAsString(value);
                if (!String.IsNullOrEmpty(errorMsg))
                {
                    e.Cancel = true;
                }
            }
            else if (col == customFormulaCol)
            {
                errorMsg = DialogUtils.ValidCustomFormula(value);
                if (!String.IsNullOrEmpty(errorMsg))
                {
                    e.Cancel = true;
                }
            }

            datagrid[e.ColumnIndex, e.RowIndex].ErrorText = errorMsg;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void baseHandlingFileCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            baseHandling = (BaseHandlingFile)Enum.Parse(typeof(BaseHandlingFile), baseHandlingFileCb.SelectedValue.ToString());
        }
    }
}
