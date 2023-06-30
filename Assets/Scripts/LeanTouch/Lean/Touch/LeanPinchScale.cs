using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanPinchScale")]
	[AddComponentMenu("Lean/Touch/Lean Pinch Scale")]
	public class LeanPinchScale : MonoBehaviour
	{
		public LeanFingerFilter Use;

		[Tooltip("The camera that will be used to calculate the zoom.\n\nNone = MainCamera.")]
		public Camera Camera;

		[Tooltip("Should the scaling be performanced relative to the finger center?")]
		public bool Relative;

		[Tooltip("The sensitivity of the scaling.\n\n1 = Default.\n2 = Double.")]
		public float Sensitivity;

		[Tooltip("If you want this component to change smoothly over time, then this allows you to control how quick the changes reach their target value.\n\n-1 = Instantly change.\n\n1 = Slowly change.\n\n10 = Quickly change.")]
		[FormerlySerializedAs("Dampening")]
		public float Damping;

		[HideInInspector]
		[SerializeField]
		private Vector3 remainingScale;

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

		protected virtual void TranslateUI(float pinchScale, Vector2 pinchScreenCenter)
		{
		}

		protected virtual void Translate(float pinchScale, Vector2 screenCenter)
		{
		}
	}
}
