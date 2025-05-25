using BepInEx;
using HarmonyLib;

namespace KillerBee
{
    [BepInPlugin("monky.killerbee", "KillerBee", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            var harmony = Harmony.CreateAndPatchAll(GetType().Assembly, "monky.killerbee");
            GorillaTagger.OnPlayerSpawned(OnGameInitialized);
        }

        void OnGameInitialized()
        {
        }

        void Update()
        {
            if (NetworkSystem.Instance.InRoom && NetworkSystem.Instance.GameModeString.Contains("MODDED"))
            {
                if (!inRoom)
                {
                    inRoom = true;
                }
            }
            else
            {
                if (inRoom)
                {
                    inRoom = false;
                }
            }
        }
    }
}