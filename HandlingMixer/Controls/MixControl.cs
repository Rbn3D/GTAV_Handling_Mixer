using HandlingMixer.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandlingMixer.Controls
{
    enum MixType
    {
        Mix,
        UseA,
        UseB,
        FixedValue
    }

    class MixControl : TableLayoutPanel
    {
        public string handlingPropName = null;

        public float mixedValue = 0f;

        public Label propertyNameLabel;
        public ComboBox mixTypeCombo;
        public TrackBar mixSlider;
        public TextBox fixedValueTextBox;


        public MixControl(string handlingPropName) : base() {

            initializeFromValue(handlingPropName);

            AutoScroll = false;
            //FlowDirection = FlowDirection.TopDown;
            //WrapContents = true;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Width = 400;

            propertyNameLabel = new Label();
            propertyNameLabel.Text = handlingPropName;
            mixTypeCombo = new ComboBox();
            mixTypeCombo.DataSource = Enum.GetValues(typeof(MixType));
            mixTypeCombo.SelectedValueChanged += MixTypeCombo_SelectedValueChanged;

            mixSlider = new TrackBar();

            mixSlider.Minimum = (int) 0;
            mixSlider.Maximum = (int) 100000;

            fixedValueTextBox = new TextBox();
            fixedValueTextBox.KeyPress += MixSlider_KeyPress;
            fixedValueTextBox.Validating += MixSlider_Validating;

            fixedValueTextBox.TextChanged += FixedValueTextBox_TextChanged;


            mixTypeCombo.SelectedValue = MixType.Mix;
            mixSlider.Value = 50000;

            this.Controls.Add(propertyNameLabel);
            this.Controls.Add(mixTypeCombo);
            this.Controls.Add(mixSlider);
            this.Controls.Add(fixedValueTextBox);
            

        }

        private void FixedValueTextBox_TextChanged(object sender, EventArgs e)
        {
            setValueFromFixedTextBox();
        }

        private void setValueFromFixedTextBox()
        {
            if(!String.IsNullOrEmpty(fixedValueTextBox.Text))
            {
                mixedValue = float.Parse(fixedValueTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
            }
        }

        private void MixSlider_ValueChanged(object sender, EventArgs e)
        {
            setMixedValueFromSlider();
        }

        private void setMixedValueFromSlider()
        {
            float value = (float)(mixSlider.Value / 100000.0);
            mixedValue = value;
        }

        private void MixTypeCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            MixType value = (MixType) mixTypeCombo.SelectedValue;

            if(value == MixType.Mix)
            {
                hideAllSubControls();
                mixSlider.Visible = true;

                setMixedValueFromSlider();

            } else if (value == MixType.UseA) {
                hideAllSubControls();

            } else if (value == MixType.UseB) {
                hideAllSubControls();

            } else if (value == MixType.FixedValue) {
                hideAllSubControls();
                fixedValueTextBox.Visible = true;

                setValueFromFixedTextBox();
            }
        }

        private void hideAllSubControls()
        {
            mixSlider.Visible = false;
            fixedValueTextBox.Visible = false;
        }

        private void MixSlider_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            float value;
            if (!float.TryParse(mixSlider.Text, out value)) { mixSlider.Text = ""; }
        }

        private void MixSlider_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
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
        }

        public void initializeFromValue(string handlingPropName)
        {
            this.handlingPropName = handlingPropName;
        }

        private void InitializeComponent()
        {

        }

        public PropData toPropData()
        {
            return new PropData(this.handlingPropName, (MixType)this.mixTypeCombo.SelectedItem, this.mixedValue);
        }
    }
}
