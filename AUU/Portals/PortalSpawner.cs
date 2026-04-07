using ULTRAKILL.Portal;
using ULTRAKILL.Portal.Geometry;
using UnityEngine;

namespace AUU.Portals {
	public static class PortalSpawner {
		private const int PortalLayer = 30;
		
		public static Portal CreatePortal(string name, Transform entry, Transform exit, PortalParameters parameters) {
			GameObject portalObject = new GameObject(name);
			portalObject.gameObject.layer = 30;
			
			Portal portal = portalObject.AddComponent<Portal>();
			portal.entry = entry;
			portal.exit = exit;

			portal.allowCameraTraversals = parameters.AllowCameraTraversals;

			portal.canSeeItself = parameters.CanSeeItself;
			portal.canSeePortalLayer = parameters.CanSeePortals;

			portal.consumeAudio = parameters.ConsumeAudio;
			portal.canHearAudio = parameters.CanHearAudio;
			
			portal.supportInfiniteRecursion = parameters.InfiniteRecursions;
			portal.appearsInRecursions = parameters.AppearsInRecursions;
			portal.maxRecursions = parameters.MaxRecursionCount;
			
			portal.minimumEntrySideSpeed = parameters.MinimumEntrySpeed;
			portal.minimumExitSideSpeed = parameters.MinimumExitSpeed;
			
			portal.mirror = parameters.IsMirror;

			portal.shape = new PlaneShape() {
				width = parameters.Size.x,
				height = parameters.Size.y
			};

			return portal;
		}
	}
}