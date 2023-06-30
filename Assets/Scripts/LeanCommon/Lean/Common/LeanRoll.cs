using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Common
{
	[AddComponentMenu("Lean/Roll")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanCommon#LeanRoll")]
	[ExecuteInEditMode]
	public class LeanRoll : MonoBehaviour
	{
		public float Angle;

		public bool Clamp;

		public float ClampMin;

		public float ClampMax;

		[FormerlySerializedAs("Dampening")]
		public float Damping;

		[SerializeField]
		private float currentAngle;

		public void IncrementAngle(float delta)
		{
		}

		public void DecrementAngle(float delta)
		{
		}

		public void RotateToDelta(Vector2 delta)
		{
		}

		[ContextMenu("Snap To Target")]
		public void SnapToTarget()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}
	}
}
