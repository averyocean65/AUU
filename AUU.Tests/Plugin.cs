using System;
using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AUU.Tests {
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
	[BepInDependency("com.averyocean65.utils")]
	public class Plugin : BaseUnityPlugin {
		private static class PluginInfo {
			public const string GUID = "com.averyocean65.utils.tests";
			public const string NAME = "AUU.Tests";
			public const string VERSION = "1.0.0";
		}

		private void Awake() {
			SceneManager.sceneLoaded += (arg0, mode) => {
				Logger.LogInfo($"Is Level: {SceneUtils.IsInLevel()}");
				
				if (!SceneUtils.IsInLevel()) {
					return;
				}

				GameObject tests = new GameObject("AUU Testing");
				tests.AddComponent<BalancingTest>();
			};
		}
	}
}