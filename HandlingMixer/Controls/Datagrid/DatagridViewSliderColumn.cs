using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandlingMixer.Controls.Datagrid
{
    class DatagridViewSliderColumn : DataGridViewColumn
    {
        public DatagridViewSliderColumn() : base(new SliderCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(SliderCell)))
                {
                    throw new InvalidCastException("Must be a SliderCell");
                }
                base.CellTemplate = value;
            }
        }
    }
}
