namespace AUU {
	public static class SceneUtils {
		public static bool IsInLevel() {
			return SceneHelper.CurrentScene != "Intro" && SceneHelper.CurrentScene != "Main Menu";
		}
	}
}