using System;
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
			
			// manual contains check, since List.Contains() doesn't seem to work... :/
			foreach (var existingReason in DisableRankReasons) {
				if (string.Equals(existingReason.Reason, reason, StringComparison.Ordinal)) {
					return null;
				}
			}
			
			DisableRankReasons.Add(reasonStruct);
			return reasonStruct;
		}

		public static void ReenableRankSubmission(DisableRankReason reason) {
			if (DisableRankReasons.Contains(reason)) {
				DisableRankReasons.Remove(reason);
			}
		}
	}
}