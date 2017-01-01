using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingMixer
{
    class Metadata
    {
        public static string[] getHandlingProperties()
        {
            return new string[] {
                "fMass",
                "fInitialDragCoeff",
                "fPercentSubmerged",
                "vecCentreOfMassOffset",
                "vecInertiaMultiplier",
                "fDriveBiasFront",
                "nInitialDriveGears",
                "fInitialDriveForce",
                "fDriveInertia",
                "fClutchChangeRateScaleUpShift",
                "fClutchChangeRateScaleDownShift",
                "fInitialDriveMaxFlatVel",
                "fBrakeForce",
                "fBrakeBiasFront",
                "fHandBrakeForce",
                "fSteeringLock",
                "fTractionCurveMax",
                "fTractionCurveMin",
                "fTractionCurveLateral",
                "fTractionSpringDeltaMax",
                "fLowSpeedTractionLossMult",
                "fCamberStiffnesss",
                "fTractionBiasFront",
                "fTractionLossMult",
                "fSuspensionForce",
                "fSuspensionCompDamp",
                "fSuspensionReboundDamp",
                "fSuspensionUpperLimit",
                "fSuspensionLowerLimit",
                "fSuspensionRaise",
                "fSuspensionBiasFront",
                "fAntiRollBarForce",
                "fAntiRollBarBiasFront",
                "fRollCentreHeightFront",
                "fRollCentreHeightRear",
                "fCollisionDamageMult",
                "fWeaponDamageMult",
                "fDeformationDamageMult",
                "fEngineDamageMult",
                "fPetrolTankVolume",
                "fOilVolume",
                "fSeatOffsetDistX",
                "fSeatOffsetDistY",
                "fSeatOffsetDistZ",
            };
        }
    }
}
