using BepInEx;

namespace AUU {
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
	public class Plugin : BaseUnityPlugin {
		private static class PluginInfo {
			public const string GUID = "com.averyocean65.utils";
			public const string NAME = "AUU";
			public const string VERSION = "0.1.0";
		}
	}
}