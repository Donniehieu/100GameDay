using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Drag Translate")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanDragTranslate")]
	public class LeanDragTranslate : MonoBehaviour
	{
		public LeanFingerFilter Use;

		[Tooltip("The camera the translation will be calculated using.\n\nNone = MainCamera.")]
		public Camera Camera;

		[Tooltip("The sensitivity of the translation.\n\n1 = Default.\n2 = Double.")]
		public float Sensitivity;

		[FormerlySerializedAs("Dampening")]
		[Tooltip("If you want this component to change smoothly over time, then this allows you to control how quick the changes reach their target value.\n\n-1 = Instantly change.\n\n1 = Slowly change.\n\n10 = Quickly change.")]
		public float Damping;

		[Range(0f, 1f)]
		[Tooltip("This allows you to control how much momenum is retained when the dragging fingers are all released.\n\nNOTE: This requires <b>Dampening</b> to be above 0.")]
		public float Inertia;

		[HideInInspector]
		[SerializeField]
		private Vector3 remainingTranslation;

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

		protected virtual void Update()
		{
		}

		private void TranslateUI(Vector2 screenDelta)
		{
		}

		private void Translate(Vector2 screenDelta)
		{
		}
	}
}
