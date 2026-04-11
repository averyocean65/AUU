namespace AUU {
	public enum SceneType {
		Intro,
		MainMenu,
		Level
	}

	public enum LevelType {
		None,
		Campaign,
		Cybergrind,
		Sandbox,
		Museum,
		Custom
	}
	
	public static class SceneUtils {
		public static SceneType GetSceneType() {
			switch (SceneHelper.CurrentScene.ToLower()) {
				case "intro":
					return SceneType.Intro;
				case "main menu":
					return SceneType.MainMenu;
				default:
					return SceneType.Level;
			}
		}

		public static LevelType GetLevelType() {
			if (!IsInLevel()) {
				return LevelType.None;
			}

			if (SceneHelper.IsPlayingCustom) {
				return LevelType.Custom;
			}
			
			switch (SceneHelper.CurrentScene.ToLower()) {
				case "uk_construct":
					return LevelType.Sandbox;
				case "endless":
					return LevelType.Cybergrind;
				case "creditsmuseum2":
					return LevelType.Museum;
				default:
					return LevelType.Campaign;
			}
		}
		
		public static bool IsInLevel() {
			return GetSceneType() == SceneType.Level;
		}
	}
}