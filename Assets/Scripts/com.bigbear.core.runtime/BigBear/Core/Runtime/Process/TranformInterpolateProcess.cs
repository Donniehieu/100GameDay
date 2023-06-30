using System.Runtime.CompilerServices;
using UnityEngine;

namespace BigBear.Core.Runtime.Process
{
	public class TranformInterpolateProcess : Process
	{
		private Transform movetransform;

		private Vector3 startPos;

		private Vector3 endPos;

		private float speed;

		private float timer;

		private float journeyLength;

		private float distCovered;

		private float fracJourney;

		public Vector3 CurrentPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void OnBegin()
		{
		}

		public override void OnTerminate()
		{
		}

		public override void Update(float dt)
		{
		}

		public void SetInfo(Transform _transform, Vector3 _startPosition, Vector3 _endPosition, float _speed)
		{
		}

		public override void Pause(bool isPause)
		{
		}
	}
}
