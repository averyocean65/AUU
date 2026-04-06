using BepInEx;

namespace AUU.Tests {
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
	public class Plugin {
		private static class PluginInfo {
			public const string GUID = "com.averyocean65.utils.tests";
			public const string NAME = "AUU.Tests";
			public const string VERSION = "1.0.0";
		}
		
		
	}
}