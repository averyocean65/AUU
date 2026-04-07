using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace AUU {
	public static class AssetBundleUtils {
		private static Dictionary<string, AssetBundle> LoadedBundles = new Dictionary<string, AssetBundle>();

		private static AssetBundle LoadAssetBundleFromFile(string path) {
			AssetBundle bundle = AssetBundle.LoadFromFile(path);
			if (bundle == null) {
				string errorMessage = $"Failed to load Asset Bundle: {path}";
				HudMessageReceiver.Instance.SendHudMessage($"<color=red>{errorMessage}</color>");
				return null;
			}

			return bundle;
		}
		
		public static AssetBundle LoadAssetBundle(string bundlePath, string bundleName) {
			string path = Path.Combine(bundlePath, bundleName);
			if (!LoadedBundles.ContainsKey(bundleName)) {
				AssetBundle bundle = LoadAssetBundleFromFile(path);
				LoadedBundles.Add(bundleName, bundle);
			}

			return LoadedBundles[bundleName];
		}

		public static void UnloadAssetBundle(string key, bool removeFromList = true) {
			if (!LoadedBundles.TryGetValue(key, out var bundle)) {
				return;
			}

			bundle.Unload(false);

			if (removeFromList) {
				LoadedBundles.Remove(key);
			}
		}
		
		public static void UnloadAllAssetBundles() {
			foreach (var kvp in LoadedBundles) {
				UnloadAssetBundle(kvp.Key, false);
			}
			
			LoadedBundles.Clear();
		}
	}
}