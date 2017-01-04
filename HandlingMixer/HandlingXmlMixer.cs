using HandlingMixer;
using HandlingMixer.Controls;
using HandlingMixer.Data;
using SimpleExpressionEvaluator;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static HandlingMixer.Metadata;

namespace HandlingMixer
{
    class HandlingXmlMixer
    {
        public string XmlAPath;
        public string XmlBPath;

        public List<PropData> mixedValues;
        public string mixedGen;

        public HandlingXmlMixer(string XmlAPath, string XmlBPath, List<PropData> mixedValues)
        {
            this.XmlAPath = XmlAPath;
            this.XmlBPath = XmlBPath;

            this.mixedValues = mixedValues;
        }

        public string generateMixedHandling()
        {
            XElement AXml = XElement.Load(XmlAPath);
            XElement BXml = XElement.Load(XmlBPath);

            // For now, just use A handling as base (this may become configurable in the future)
            XElement MixXml = XElement.Load(XmlAPath);

            var mixItems = MixXml.Elements().Elements();

            var aItems = AXml.Elements();
            var bItems = BXml.Elements();

            foreach(var mixItem in mixItems)
            {
                string carName = mixItem.Element("handlingName").Value;

                var carA = from c in aItems.Elements()
                           where carName == c.Element("handlingName").Value
                           select c;

                var carB = from c in bItems.Elements()
                           where carName == c.Element("handlingName").Value
                           select c;

                foreach (PropData mixProp in mixedValues)
                {
                    var pName = mixProp.propName;
                    var pDataType = mixProp.mixType;
                    var pDataValue = mixProp.mixedValue;

                    string[] attributesToMix = { "value" };
                    string[] attributesToMixVector = { "x","y","z" };

                    if(mixProp.dataType == HandlingDataType.Vector3)
                    {
                        attributesToMix = attributesToMixVector;
                    }

                    foreach(var att in attributesToMix)
                    {
                        var AValue = MathUtils.FloatFromString(carA.Elements(pName).First().Attributes(att).First().Value);
                        var BValue = MathUtils.FloatFromString(carB.Elements(pName).First().Attributes(att).First().Value);

                        var mixedValue = 0f;

                        if (pDataType == MixType.FixedValue)
                        {
                            mixedValue = pDataValue;
                        }
                        else if (pDataType == MixType.Mix)
                        {
                            mixedValue = MathUtils.Lerp(AValue, BValue, pDataValue);
                        }
                        else if (pDataType == MixType.UseA)
                        {
                            mixedValue = AValue;
                        }
                        else if (pDataType == MixType.UseB)
                        {
                            mixedValue = BValue;
                        }

                        mixedValue = processAditionalMathColumns(mixedValue, mixProp);

                        // round to int if handling data type should be integer
                        if(mixProp.dataType == HandlingDataType.Int)
                        {
                            mixedValue = (float)Math.Round((double)mixedValue);
                        }

                        mixItem.Element(pName).Attribute(att).Value = mixedValue.ToString(CultureInfo.InvariantCulture);
                    }

                }
            }

            var xml = MixXml.ToString();
            return @"<?xml version=""1.0"" encoding=""UTF - 8""?>

" + xml;
        }

        // Process Offset, Multiplier, Custom formula, Minimum, Maximum columns
        private float processAditionalMathColumns(float mixedValue, PropData mixProp)
        {
            var offset = mixProp.valueOffset;
            var multiplier = mixProp.ValueMultiplier;
            var customFormula = mixProp.customFormula;
            var min = mixProp.MinimumValue;
            var max = mixProp.MaximumValue;

            // offset
            mixedValue += offset;

            //multiplier
            mixedValue *= multiplier;

            // custom formula
            if(!String.IsNullOrWhiteSpace(customFormula))
            {
                dynamic ev = new ExpressionEvaluator(CultureInfo.InvariantCulture);

                Decimal x = 0;
                Decimal.TryParse(mixedValue.ToString(CultureInfo.InvariantCulture), out x);

                mixedValue = ev.Evaluate(customFormula, x: x);
            }

            // min
            if(!String.IsNullOrWhiteSpace(min))
            {
                var floatMin = MathUtils.FloatFromString(min);

                if(mixedValue < floatMin)
                {
                    mixedValue = floatMin;
                }
            }

            // max
            if (!String.IsNullOrWhiteSpace(max))
            {
                var floatMax = MathUtils.FloatFromString(max);

                if (mixedValue > floatMax)
                {
                    mixedValue = floatMax;
                }
            }

            return mixedValue;
        }
    }
}
