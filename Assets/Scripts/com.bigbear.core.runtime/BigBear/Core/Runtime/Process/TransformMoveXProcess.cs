using UnityEngine;

namespace BigBear.Core.Runtime.Process
{
	public class TransformMoveXProcess : LinearInterpolateProcess
	{
		protected Transform transform;

		private Vector3 curPos;

		public TransformMoveXProcess(Transform transform, float start, float end, float speed)
			: base(0f, 0f, 0f, 0f)
		{
		}

		public override void TimedUpdate()
		{
		}

		public void SetInfo(float start, float end)
		{
		}

		public void Reset()
		{
		}
	}
}
