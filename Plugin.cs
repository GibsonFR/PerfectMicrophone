global using BepInEx;
global using BepInEx.IL2CPP;
global using HarmonyLib;
global using UnityEngine;
global using UnhollowerRuntimeLib;
using Dissonance.Config;

namespace BetterMovement
{
    [BepInPlugin("26A0C2CA-5DD9-42D6-845A-9FFB0526D9F0", "PerfectMicrophone", "1.0.0")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            Harmony.CreateAndPatchAll(typeof(Plugin));
            Log.LogInfo("Mod created by Gibson, discord : gib_son");
        }

        //Set ClientId
        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Awake))]
        [HarmonyPostfix]
        public static void OnSteamManagerAwake(SteamManager __instance)
        {
            VoiceSettings voiceSettingsInstance = VoiceSettings.Instance;

            voiceSettingsInstance._quality = EnumPublicSealedvaStPoToLoMeHi7vUnique.High;
            voiceSettingsInstance.Quality = EnumPublicSealedvaStPoToLoMeHi7vUnique.High;
            voiceSettingsInstance.BackgroundSoundRemovalAmount = 0;
            voiceSettingsInstance.VoiceDuckLevel = 0;
            voiceSettingsInstance.FrameSize = EnumPublicSealedvaTiSmMeLa5vUnique.Large;
            voiceSettingsInstance._frameSize = EnumPublicSealedvaTiSmMeLa5vUnique.Large;
            voiceSettingsInstance.AecmRoutingMode = EnumPublicSealedvaDiQuEaLoSp7vLoUnique.Disabled;
            voiceSettingsInstance.VadSensitivity = EnumPublicSealedvaLoMeHiVe5vUnique.VeryHighSensitivity;
        }

        //Anticheat Bypass 
        [HarmonyPatch(typeof(EffectManager), "Method_Private_Void_GameObject_Boolean_Vector3_Quaternion_0")]
        [HarmonyPatch(typeof(LobbyManager), "Method_Private_Void_0")]
        [HarmonyPatch(typeof(MonoBehaviourPublicVesnUnique), "Method_Private_Void_0")]
        [HarmonyPatch(typeof(LobbySettings), "Method_Public_Void_PDM_2")]
        [HarmonyPatch(typeof(MonoBehaviourPublicTeplUnique), "Method_Private_Void_PDM_32")]
        [HarmonyPrefix]
        public static bool Prefix(System.Reflection.MethodBase __originalMethod)
        {
            return false;
        }
    }
}