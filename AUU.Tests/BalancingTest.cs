using UnityEngine;

namespace AUU.Tests {
	public class BalancingTest : MonoBehaviour {
		private bool disabledSubmission = false;
		
		private void Update() {
			if (Input.GetKeyDown(KeyCode.Alpha9) && !disabledSubmission) {
				HudMessageReceiver.Instance.SendHudMessage("<color=red>Level Submission Disabled</color> by AUU.Tests");
				BalancingManager.DisableRankSubmission("AUU.TESTS ENGAGED", new Color(1, 0, 0));
				disabledSubmission = true;
			}
		}
	}
}