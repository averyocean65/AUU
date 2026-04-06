using UnityEngine;

namespace AUU {
	public class DisableRankReason {
		public Color TextColor;
		public string Reason;

		public DisableRankReason(string reason, Color textColor) {
			Reason = reason;
			TextColor = textColor;
		}

		public override string ToString() {
			return $"<color=white>-</color> <color=#{ColorUtility.ToHtmlStringRGB(TextColor)}>{Reason}</color>\n";
		}
	}
}