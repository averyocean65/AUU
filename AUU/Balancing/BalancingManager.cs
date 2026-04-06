using System.Collections.Generic;
using UnityEngine;

namespace AUU {
	public static class BalancingManager {
		internal static readonly List<DisableRankReason> DisableRankReasons = new List<DisableRankReason>();

		public static DisableRankReason DisableRankSubmission(string reason, Color color) {
			if (string.IsNullOrEmpty(reason)) {
				return null;
			}
			
			DisableRankReason reasonStruct = new DisableRankReason(reason, color);
			if (DisableRankReasons.Contains(reasonStruct)) {
				return null;
			}
			
			DisableRankReasons.Add(reasonStruct);
			return reasonStruct;
		}
	}
}