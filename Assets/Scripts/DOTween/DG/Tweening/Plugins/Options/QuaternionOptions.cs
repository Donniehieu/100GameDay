using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	public struct QuaternionOptions : IPlugOptions
	{
		public RotateMode rotateMode;

		public AxisConstraint axisConstraint;

		public Vector3 up;

		public bool dynamicLookAt;

		public Vector3 dynamicLookAtWorldPosition;

		public void Reset()
		{
		}
	}
}
