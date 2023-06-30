using UnityEngine;

namespace Lean.Touch
{
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanTwistRotateAxis")]
	[AddComponentMenu("Lean/Touch/Lean Twist Rotate Axis")]
	public class LeanTwistRotateAxis : MonoBehaviour
	{
		public LeanFingerFilter Use;

		[Tooltip("The axis of rotation.")]
		public Vector3 Axis;

		[Tooltip("Rotate locally or globally?")]
		public Space Space;

		[Tooltip("The sensitivity of the rotation.\n\n1 = Default.\n2 = Double.")]
		public float Sensitivity;

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
	}
}
