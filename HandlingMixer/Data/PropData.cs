using HandlingMixer.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingMixer.Data
{
    class PropData
    {
        public PropData(string propName, MixType mixType, float mixedValue)
        {
            this.propName = propName;
            this.mixType = mixType;
            this.mixedValue = mixedValue;
        }

        public string propName;
        public MixType mixType;

        public float mixedValue;
    }
}
