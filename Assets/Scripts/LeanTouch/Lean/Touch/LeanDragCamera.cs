using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Drag Camera")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanDragCamera")]
	public class LeanDragCamera : MonoBehaviour
	{
		public LeanFingerFilter Use;

		public LeanScreenDepth ScreenDepth;

		[Tooltip("The movement speed will be multiplied by this.\n\n-1 = Inverted Controls.")]
		public float Sensitivity;

		[FormerlySerializedAs("Dampening")]
		[Tooltip("If you want this component to change smoothly over time, then this allows you to control how quick the changes reach their target value.\n\n-1 = Instantly change.\n\n1 = Slowly change.\n\n10 = Quickly change.")]
		public float Damping;

		[Range(0f, 1f)]
		[Tooltip("This allows you to control how much momenum is retained when the dragging fingers are all released.\n\nNOTE: This requires <b>Dampening</b> to be above 0.")]
		public float Inertia;

		[SerializeField]
		[HideInInspector]
		private Vector3 remainingDelta;

		[ContextMenu("Move To Selection")]
		public virtual void MoveToSelection()
		{
		}

		public void AddFinger(LeanFinger finger)
		{
		}

		public void RemoveFinger(LeanFinger finger)
		{
		}

		public void RemoveAllFingers()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void LateUpdate()
		{
		}
	}
}
