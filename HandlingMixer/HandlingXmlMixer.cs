using HandlingMixer;
using HandlingMixer.Controls;
using HandlingMixer.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

                    // @TODO: check "value" vs "x" "y" "z" attributes in a fancier way (avoid try catch for best performance)
                    try
                    {
                        var test = carA.Elements(pName).First().Attributes("value").First().Value;
                    }
                    catch (Exception e)
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

                        mixItem.Element(pName).Attribute(att).Value = mixedValue.ToString(CultureInfo.InvariantCulture);
                    }

                }
            }

            var xml = MixXml.ToString();
            return @"<?xml version=""1.0"" encoding=""UTF - 8""?>

" + xml;
        }

    }
}
