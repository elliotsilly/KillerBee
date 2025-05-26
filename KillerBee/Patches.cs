using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;

namespace KillerBee
{
    [HarmonyPatch(typeof(AngryBeeSwarm), "LateUpdate")]
    public class BeePatches
    {
        public static void Postfix(AngryBeeSwarm __instance)
        {
            if (__instance.currentState == AngryBeeSwarm.ChaseState.Grabbing &&
                __instance.targetPlayer.ActorNumber == PhotonNetwork.LocalPlayer.ActorNumber)
            {
                Application.Quit();
            }
        }
    }
}
