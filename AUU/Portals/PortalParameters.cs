using UnityEngine;

namespace AUU.Portals {
	public class PortalParameters {
		public bool AllowCameraTraversals = true;
		
		public bool CanSeeItself = true;
		public bool CanSeePortals = true;

		public bool ConsumeAudio = true;
		public bool CanHearAudio = true;
		
		public bool InfiniteRecursions = false;
		public bool AppearsInRecursions = true;
		public bool IsMirror = false;
		
		public int MaxRecursionCount = 3;

		public float MinimumEntrySpeed = 0.0f;
		public float MinimumExitSpeed = 0.0f;

		public Vector2 Size = Vector2.one;
	}
}