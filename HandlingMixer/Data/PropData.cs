using HandlingMixer.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HandlingMixer.Metadata;

namespace HandlingMixer.Data
{
    [Serializable]
    public class PropData
    {
        public PropData()
        {

        }

        public PropData(string propName, HandlingDataType dataType, MixType mixType, float mixedValue)
        {
            this.propName = propName;
            this.dataType = dataType;
            this.mixType = mixType;
            this.mixedValue = mixedValue;
        }

        public string propName { get; set; }
        public HandlingDataType dataType { get; set; }
        public MixType mixType { get; set; }
        public float mixedValue { get; set; }

        private float _valueOffset = 0f;
        public float valueOffset
        {
            get { return _valueOffset; }
            set { _valueOffset = value; }
        }

        private float _valueMultiplier = 1f;
        public float ValueMultiplier
        {
            get { return _valueMultiplier; }
            set { _valueMultiplier = value; }
        }

        private string _customFormula = "";
        public string customFormula
        {
            get { return _customFormula; }
            set { _customFormula = value; }
        }

        private string _clampMin = "";
        public string MinimumValue
        {
            get { return _clampMin; }
            set { _clampMin = value; }
        }

        private string _clampMax = "";

        public string MaximumValue
        {
            get { return _clampMax; }
            set { _clampMax = value; }
        }

    }
}
