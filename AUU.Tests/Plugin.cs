using System;
using AUU.Portals;
using BepInEx;
using ULTRAKILL.Portal;
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

				Portal testPortal = PortalSpawner.CreatePortal("My Portal",
					tests.transform,
					tests.transform,
					new PortalParameters() {
						Size = Vector2.one * 20,
						MinimumEntrySpeed = 0,
						MinimumExitSpeed = 20,
						CanSeeItself = false
					});
			};
		}
	}
}