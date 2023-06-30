using System;
using UnityEngine;

namespace BigBear.Core.Runtime.Process
{
	public class TransformScaleProcess : Vector3InterpolateProcess
	{
		protected Transform transform;

		public void SetInfo(Transform _transform, Vector3 _fromScale, Vector3 _toScale, float _duration, float _delay = 0f, AnimationCurve _easeCurve = null, Action _onCompletedAction = null)
		{
		}

		public override void TimeUpdated()
		{
		}
	}
}
