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
        public enum MixType
        {
            Mix,
            UseA,
            UseB,
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
    }
}
