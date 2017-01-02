using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controls.Datagrid;

namespace HandlingMixer.Controls.Datagrid
{
    class SliderCell : DataGridViewCell
    {
        public SliderCell() : base()
        {
            // Use the short date format.
            //this.Style.Format = "d";
        }

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            SliderEditingControl ctl =
                DataGridView.EditingControl as SliderEditingControl;
            // Use the default row value when Value property is null.
            if (this.Value == null)
            {
                ctl.Value = (int)this.DefaultNewRowValue;
            }
            else
            {
                ctl.Value = (int)this.Value;
            }
        }

        public override Type EditType
        {
            get
            {
                // Return the type of the editing control that SliderCell uses.
                return typeof(SliderEditingControl);
            }
        }

        public override Type ValueType
        {
            get
            {
                // Return the type of the value that SliderCell contains.

                return typeof(int);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                return 50000;
            }
        }
    }
}
