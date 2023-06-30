using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Twist Rotate")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanTwistRotate")]
	public class LeanTwistRotate : MonoBehaviour
	{
		public LeanFingerFilter Use;

		[Tooltip("The camera we will be used to calculate relative rotations.\n\nNone = MainCamera.")]
		public Camera Camera;

		[Tooltip("Should the rotation be performanced relative to the finger center?")]
		public bool Relative;

		[Tooltip("If you want this component to change smoothly over time, then this allows you to control how quick the changes reach their target value.\n\n-1 = Instantly change.\n\n1 = Slowly change.\n\n10 = Quickly change.")]
		[FormerlySerializedAs("Dampening")]
		public float Damping;

		[HideInInspector]
		[SerializeField]
		private Vector3 remainingTranslation;

		[SerializeField]
		[HideInInspector]
		private Quaternion remainingRotation;

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

		protected virtual void TranslateUI(float twistDegrees, Vector2 twistScreenCenter)
		{
		}

		protected virtual void Translate(float twistDegrees, Vector2 twistScreenCenter)
		{
		}

		protected virtual void RotateUI(float twistDegrees)
		{
		}

		protected virtual void Rotate(float twistDegrees)
		{
		}
	}
}
