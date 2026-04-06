using HarmonyLib;

namespace AUU.Patches {
	[HarmonyPatch]
	public static class LevelPatches {
		[HarmonyPostfix]
        [HarmonyPatch(typeof(FinalRank), nameof(FinalRank.SetInfo))]
        static void SetInfoPatch(ref FinalRank __instance, int restarts, bool damage, bool majorUsed, bool cheatsUsed) {
            foreach (var reason in BalancingManager.DisableRankReasons) {
	            __instance.extraInfo.text += reason.ToString();
            }
        }
        
        [HarmonyPrefix]
        [HarmonyPatch(typeof(GameProgressSaver), nameof(GameProgressSaver.SaveRank))]
        static void SaveRankPatch(ref bool __runOriginal) {
	        if (BalancingManager.DisableRankReasons.Count > 0) {
		        // for reference: this blocks the actual GameProgressSaver.SaveRank function from running.
		        __runOriginal = false;
	        }
        }
        
        [HarmonyPrefix]
        [HarmonyPatch(typeof(FinalCyberRank), nameof(FinalCyberRank.GameOver))]
        static void GameOverPatch() {
	        if (BalancingManager.DisableRankReasons.Count > 0) {
		        StatsManager.Instance.majorUsed = true;
	        }
        }
        
        [HarmonyPrefix]
        [HarmonyPatch(typeof(LeaderboardController), nameof(LeaderboardController.SubmitLevelScore))]
        static void SubmitLevelScorePatch(ref bool __runOriginal) {
	        if (BalancingManager.DisableRankReasons.Count > 0) {
		        __runOriginal = false;
	        }
        }
	}
}