using System;
using BigBear.Core.Runtime.Pool;
using UnityEngine;

namespace BigBear.Core.Runtime.Process
{
	public class TransformInterpolateProcess : Vector3InterpolateProcess, IPoolable
	{
		protected Transform transform;

		private bool isWorldInterpolate;

		public void SetInfo(Transform _transform, Vector3 _fromPos, Vector3 _toPos, float _duration, bool _isWorldInterpolate = true, float _delay = 0f, AnimationCurve _easeCurve = null, Action _onCompletedAction = null)
		{
		}

		public override void TimeUpdated()
		{
		}
	}
}
