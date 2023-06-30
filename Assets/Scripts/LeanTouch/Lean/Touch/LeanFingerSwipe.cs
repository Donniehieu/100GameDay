using UnityEngine;

namespace Lean.Touch
{
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanFingerSwipe")]
	[AddComponentMenu("Lean/Touch/Lean Finger Swipe")]
	public class LeanFingerSwipe : LeanSwipeBase
	{
		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public LeanSelectable RequiredSelectable;

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void HandleFingerSwipe(LeanFinger finger)
		{
		}
	}
}
