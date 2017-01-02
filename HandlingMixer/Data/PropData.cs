using HandlingMixer.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HandlingMixer.Metadata;

namespace HandlingMixer.Data
{
    class PropData
    {
        public PropData(string propName, HandlingDataType dataType, MixType mixType, float mixedValue)
        {
            this.propName = propName;
            this.dataType = dataType;
            this.mixType = mixType;
            this.mixedValue = mixedValue;
        }

        public string propName;
        public HandlingDataType dataType;
        public MixType mixType;
        public float mixedValue;
    }
}
