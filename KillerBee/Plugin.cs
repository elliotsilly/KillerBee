using BepInEx;
using HarmonyLib;

namespace KillerBee
{
    [BepInPlugin("monky.killerbee", "KillerBee", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            Harmony.CreateAndPatchAll(GetType().Assembly, "monky.killerbee");
        }
    }
}
