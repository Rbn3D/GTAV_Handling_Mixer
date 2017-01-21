extern alias NCalc;

using HandlingMixer;
using HandlingMixer.Data;
using NCalc::NCalc;
using SimpleLogger;
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
        public BaseHandlingFile baseHandling;

        public HandlingXmlMixer(string XmlAPath, string XmlBPath, List<PropData> mixedValues, BaseHandlingFile baseHandling)
        {
            this.XmlAPath = XmlAPath;
            this.XmlBPath = XmlBPath;

            this.mixedValues = mixedValues;
            this.baseHandling = baseHandling;
        }

        public string generateMixedHandling()
        {
            XElement AXml = XElement.Load(XmlAPath);
            XElement BXml = XElement.Load(XmlBPath);

            // Set base handling based on user selection
            XElement MixXml = baseHandling == BaseHandlingFile.UseA ? XElement.Load(XmlAPath) : XElement.Load(XmlBPath);

            Logger.Log("Starting mix:");
            Logger.Log("Handling A: " + XmlAPath);
            Logger.Log("Handling B: " + XmlBPath);
            Logger.Log("Base Handling" + baseHandling.ToString());

            var mixItems = MixXml.Elements().Elements();

            var aItems = AXml.Elements();
            var bItems = BXml.Elements();

            foreach (var mixItem in mixItems)
            {
                string carName = mixItem.Element("handlingName").Value;

                try { 

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
                        string[] attributesToMixVector = { "x", "y", "z" };

                        if (mixProp.dataType == HandlingDataType.Vector3)
                        {
                            attributesToMix = attributesToMixVector;
                        }

                        foreach (var att in attributesToMix)
                        {
                            var AValue = MathUtils.DecimalFromString(carA.Elements(pName).First().Attributes(att).First().Value);
                            var BValue = MathUtils.DecimalFromString(carB.Elements(pName).First().Attributes(att).First().Value);

                            var mixedValue = 0m;

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
                            else if (pDataType == MixType.UseMin)
                            {
                                mixedValue = Math.Min(AValue, BValue);
                            }
                            else if (pDataType == MixType.UseMax)
                            {
                                mixedValue = Math.Max(AValue, BValue);
                            }

                            mixedValue = processAditionalMathColumns(mixedValue, AValue, BValue, mixProp);

                            // round to int if handling data type should be integer
                            if (mixProp.dataType == HandlingDataType.Int)
                            {
                                mixedValue = (decimal)Math.Round((double)mixedValue);
                            }

                            mixItem.Element(pName).Attribute(att).Value = mixedValue.ToString(CultureInfo.InvariantCulture);
                        }

                    }

                }
                catch (Exception e)
                {
                    Logger.Log("Exception while mixing vehicle " + carName + ". This vehicle may be not present on one the handling files. (Mix will continue)");
                    Logger.Log(e);
                }
            }

            var xml = MixXml.ToString();
            xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>

" + xml;

            Logger.Log("Mix done!");

            return xml;
        }

        // Process Offset, Multiplier, Custom formula, Minimum, Maximum columns
        private decimal processAditionalMathColumns(decimal mixedValue, decimal AValue, decimal BValue, PropData mixProp)
        {
            decimal offset = mixProp.valueOffset;
            decimal multiplier = mixProp.ValueMultiplier;
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
                var expr = new Expression(customFormula);

                Decimal x = 0;
                Decimal.TryParse(mixedValue.ToString(CultureInfo.InvariantCulture), out x);

                expr.Parameters.Add("x", x);
                expr.Parameters.Add("a", AValue);
                expr.Parameters.Add("b", BValue);

                var f = expr.ToLambda<decimal>();

                mixedValue = f();
            }

            // min
            if(!String.IsNullOrWhiteSpace(min))
            {
                var floatMin = MathUtils.DecimalFromString(min);

                if(mixedValue < floatMin)
                {
                    mixedValue = floatMin;
                }
            }

            // max
            if (!String.IsNullOrWhiteSpace(max))
            {
                var floatMax = MathUtils.DecimalFromString(max);

                if (mixedValue > floatMax)
                {
                    mixedValue = floatMax;
                }
            }

            return mixedValue;
        }
    }
}
