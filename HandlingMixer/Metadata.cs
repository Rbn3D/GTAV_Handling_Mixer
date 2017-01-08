using HandlingMixer.Controls;
using HandlingMixer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingMixer
{
    public class Metadata
    {
        public const string PROPNAME_COL    = "propName";
        public const string DATATYPE_COL    = "dataType";
        public const string MIXTYPE_COL     = "mixType";
        public const string MIXEDVAL_COL    = "mixedValue";
        public const string VALOFFSET_COL   = "valueOffset";
        public const string VALMULT_COL     = "valueMultiplier";
        public const string CUSTOMFORM_COL  = "customFormula";
        public const string MINVAL_COL      = "MinimumValue";
        public const string MAXVAL_COL      = "MaximumValue";

        public enum MixType
        {
            Mix,
            UseA,
            UseB,
            UseMin,
            UseMax,
            FixedValue
        }

        public enum HandlingDataType
        {
            Float, Int, Vector3
        }

        public static List<PropData> getHandlingProperties()
        {
            List<PropData> properties = new List<PropData>();

            properties.Add(new PropData("fMass", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fInitialDragCoeff", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fPercentSubmerged", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("vecCentreOfMassOffset", HandlingDataType.Vector3, MixType.Mix, 0.5f));
            properties.Add(new PropData("vecInertiaMultiplier", HandlingDataType.Vector3, MixType.Mix, 0.5f));
            properties.Add(new PropData("fDriveBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("nInitialDriveGears", HandlingDataType.Int, MixType.Mix, 0.5f));
            properties.Add(new PropData("fInitialDriveForce", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fDriveInertia", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fClutchChangeRateScaleUpShift", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fClutchChangeRateScaleDownShift", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fInitialDriveMaxFlatVel", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fBrakeForce", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fBrakeBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fHandBrakeForce", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSteeringLock", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fTractionCurveMax", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fTractionCurveMin", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fTractionCurveLateral", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fTractionSpringDeltaMax", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fLowSpeedTractionLossMult", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fCamberStiffnesss", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fTractionBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fTractionLossMult", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSuspensionForce", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSuspensionCompDamp", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSuspensionReboundDamp", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSuspensionUpperLimit", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSuspensionLowerLimit", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSuspensionRaise", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSuspensionBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fAntiRollBarForce", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fAntiRollBarBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fRollCentreHeightFront", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fRollCentreHeightRear", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fCollisionDamageMult", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fWeaponDamageMult", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fDeformationDamageMult", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fEngineDamageMult", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fPetrolTankVolume", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fOilVolume", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSeatOffsetDistX", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSeatOffsetDistY", HandlingDataType.Float, MixType.Mix, 0.5f));
            properties.Add(new PropData("fSeatOffsetDistZ", HandlingDataType.Float, MixType.Mix, 0.5f));

            return properties;
        }

        public static string getHelpStringForColumn(string columnName)
        {
            if(!Settings.ShowHelpTooltips)
            {
                return "";
            }

            if (columnName == MIXTYPE_COL)
            {
                return
                    @"Mix type: This modifier determines how values from A and B handling files will be mixed for the current handling property.

Possible values are:
 - Mix: Use to linearly interpolate value between A and B handling for the current property
 - Use A: Take value from A handling for the current property (no interpolation)
 - Use B: Take value from B handling for the current property (no interpolation)
 - Use Max: Take value from those handling that as a higher value for the current property (no interpolation)
 - Use Min: Take value from those handling that as a lower value for the current property (no interpolation)
 - Fixed Value: (NOT RECOMENDED) Specify a fixed value for this property (this will effectively make all vehicles have the same value for this property)
";
            } 
            else if(columnName == MIXEDVAL_COL)
            {
                return @"Mixed Value (Float)
This modifier only applies for ""Mix"" and ""Fixed Value"" mix types:

 - When mixType = ""Mix"": This value is the interpolation factor between A and B, where 0.0 means 100% A, 0.5 means perfect mix, and 1 means 100% B. Interpolation is not clamped, so values below 0.0 and above 1.0 are also supported.
 - When mixType = ""FixedValue"": This value will be set directly to handling (the one you type)
";
            }
            else if (columnName == VALOFFSET_COL)
            {
                return @"Value offset (Float)

A float value, possitive or negative, that will be added to the mix value
(possive will sum, negative wil substract, 0 won't have any effect)
";
            }
            else if (columnName == VALMULT_COL)
            {
                return @"Value multiplier (Float)

A float value, usually positive, that will be multiplied to the mix value
(higher than 1.0 increases final value, lower than 1.0 will decrease value, 0 will set value to zero, lower than 0 is not recommended, 1.0 won't have any effect)
";
            }
            else if (columnName == CUSTOMFORM_COL)
            {
                return @"Custom Formula (String, can be empty)

A custom math formula that (if set) will be evaluated to calculate the final value. You have to use ""x"" variable, which stores the value for this property, and/or ""a"" and ""b"" variables.
If you don't use variables in the formula, the generated value may be the same for all vehicles.

Only use this modifier if the other ones (offset, multiplier, etc) cannot suit your needs. Also, use only if you know what you are doing.

Defined variables are:
 - x: The current calculated value for this property (this is, the value already mixed and with offset and multiplier applied)
 - a: The value in handling A for this property
 - b: The value in handling B for this property

Example: 
   (b * 2) + 100
   This example takes value from handling b, multiplies it by 2, and then add 100 to it

Please note that very complex math operations may not be supported, if you type something that the math evaluator cannot parse, an error message will be shown";

            }
            else if (columnName == MINVAL_COL)
            {
                return @"Minimum Value (Float, can be empty)

Setting this modifier will make the calculated final value to never be lower than the minimum set here";
            }
            else if (columnName == MAXVAL_COL)
            {
                return @"Maximum Value (Float, can be empty)

Setting this modifier will make the calculated final value to never be higher than the maximum set here";
            }

            return "";
        }
    }
}
