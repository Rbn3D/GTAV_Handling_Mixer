using HandlingMixer.Controls;
using HandlingMixer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingMixer
{
    class Metadata
    {
        public enum HandlingDataType
        {
            Float, Int, Vector3
        }

        public static Dictionary<string, PropData> getHandlingProperties()
        {
            Dictionary<string, PropData> properties = new Dictionary<string, PropData>();

                properties.Add("fMass",                                new PropData("fMass", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fInitialDragCoeff",                    new PropData("fInitialDragCoeff", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fPercentSubmerged",                    new PropData("fPercentSubmerged", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("vecCentreOfMassOffset",                new PropData("vecCentreOfMassOffset", HandlingDataType.Vector3, MixType.Mix, 0.5f));
                properties.Add("vecInertiaMultiplier",                 new PropData("vecInertiaMultiplier", HandlingDataType.Vector3, MixType.Mix, 0.5f));
                properties.Add("fDriveBiasFront",                      new PropData("fDriveBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("nInitialDriveGears",                   new PropData("nInitialDriveGears", HandlingDataType.Int, MixType.Mix, 0.5f));
                properties.Add("fInitialDriveForce",                   new PropData("fInitialDriveForce", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fDriveInertia",                        new PropData("fDriveInertia", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fClutchChangeRateScaleUpShift",        new PropData("fClutchChangeRateScaleUpShift", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fClutchChangeRateScaleDownShift",      new PropData("fClutchChangeRateScaleDownShift", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fInitialDriveMaxFlatVel",              new PropData("fInitialDriveMaxFlatVel", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fBrakeForce",                          new PropData("fBrakeForce", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fBrakeBiasFront",                      new PropData("fBrakeBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fHandBrakeForce",                      new PropData("fHandBrakeForce", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSteeringLock",                        new PropData("fSteeringLock", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fTractionCurveMax",                    new PropData("fTractionCurveMax", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fTractionCurveMin",                    new PropData("fTractionCurveMin", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fTractionCurveLateral",                new PropData("fTractionCurveLateral", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fTractionSpringDeltaMax",              new PropData("fTractionSpringDeltaMax", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fLowSpeedTractionLossMult",            new PropData("fLowSpeedTractionLossMult", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fCamberStiffnesss",                    new PropData("fCamberStiffnesss", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fTractionBiasFront",                   new PropData("fTractionBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fTractionLossMult",                    new PropData("fTractionLossMult", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSuspensionForce",                     new PropData("fSuspensionForce", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSuspensionCompDamp",                  new PropData("fSuspensionCompDamp", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSuspensionReboundDamp",               new PropData("fSuspensionReboundDamp", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSuspensionUpperLimit",                new PropData("fSuspensionUpperLimit", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSuspensionLowerLimit",                new PropData("fSuspensionLowerLimit", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSuspensionRaise",                     new PropData("fSuspensionRaise", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSuspensionBiasFront",                 new PropData("fSuspensionBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fAntiRollBarForce",                    new PropData("fAntiRollBarForce", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fAntiRollBarBiasFront",                new PropData("fAntiRollBarBiasFront", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fRollCentreHeightFront",               new PropData("fRollCentreHeightFront", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fRollCentreHeightRear",                new PropData("fRollCentreHeightRear", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fCollisionDamageMult",                 new PropData("fCollisionDamageMult", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fWeaponDamageMult",                    new PropData("fWeaponDamageMult", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fDeformationDamageMult",               new PropData("fDeformationDamageMult", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fEngineDamageMult",                    new PropData("fEngineDamageMult", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fPetrolTankVolume",                    new PropData("fPetrolTankVolume", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fOilVolume",                           new PropData("fOilVolume", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSeatOffsetDistX",                     new PropData("fSeatOffsetDistX", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSeatOffsetDistY",                     new PropData("fSeatOffsetDistY", HandlingDataType.Float, MixType.Mix, 0.5f));
                properties.Add("fSeatOffsetDistZ",                     new PropData("fSeatOffsetDistZ", HandlingDataType.Float, MixType.Mix, 0.5f));

            return properties;
        }
    }
}
