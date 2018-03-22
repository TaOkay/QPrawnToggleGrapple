using System;
using Harmony;

namespace QPrawnToggleGrapple.Patches
{
    [HarmonyPatch(typeof(ExosuitGrapplingArm))]
    [HarmonyPatch("OnAltDown")]
    internal class ExosuitGrapplingArm_OnAltDown_Patch
    {
        private static void Postfix(ExosuitGrapplingArm __instance)
        {
            Console.WriteLine("ExosuitGrapplingArm.OnAltDown() Postfix is working!");
        }
    }
}