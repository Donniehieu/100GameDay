using UnityEngine;

namespace Lean.Touch
{
	public abstract class LeanSelectBase : MonoBehaviour
	{
		public enum SelectType
		{
			None = -1,
			Raycast3D = 0,
			Overlap2D = 1,
			CanvasUI = 2,
			ScreenDistance = 3,
			Intersect2D = 4
		}

		public enum SearchType
		{
			GetComponent = 0,
			GetComponentInParent = 1,
			GetComponentInChildren = 2
		}

		public SelectType SelectUsing;

		public SelectType SelectUsingAlt;

		public SelectType SelectUsingAltAlt;

		public SearchType Search;

		public Camera Camera;

		public LayerMask LayerMask;

		public string RequiredTag;

		public float MaxScreenDistance;

		private static RaycastHit[] raycastHits;

		private static RaycastHit2D[] raycastHit2Ds;

		public void SelectStartScreenPosition(LeanFinger finger)
		{
		}

		public void SelectScreenPosition(LeanFinger finger)
		{
		}

		public void SelectScreenPosition(LeanFinger finger, Vector2 screenPosition)
		{
		}

		protected abstract void TrySelect(LeanFinger finger, Component component, Vector3 worldPosition);

		protected void TryGetComponent(SelectType selectUsing, Vector2 screenPosition, ref Component component, ref Vector3 worldPosition)
		{
		}

		private static int GetClosestRaycastHitsIndex(int count)
		{
			return 0;
		}

		private static Vector2 GetScreenPoint(Camera camera, Transform transform)
		{
			return default(Vector2);
		}
	}
}
