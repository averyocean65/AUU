using System;
using BepInEx;
using HarmonyLib;
using UnityEngine.SceneManagement;

namespace AUU {
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
	public class Plugin : BaseUnityPlugin {
		private static class PluginInfo {
			public const string GUID = "com.averyocean65.utils";
			public const string NAME = "AUU";
			public const string VERSION = "1.0.0";
		}

		private void Awake() {
			Harmony harmony = new Harmony(PluginInfo.GUID);
			harmony.PatchAll();

			SceneManager.sceneLoaded += (arg0, mode) => {
				BalancingManager.DisableRankReasons.Clear();
			};
		}
	}
}