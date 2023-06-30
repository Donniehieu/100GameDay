using System;
using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.Pool;
using UnityEngine;

namespace BigBear.Core.Runtime.Process
{
	public class Vector3InterpolateProcess : Process, IPoolable
	{
		protected Vector3 fromVector3;

		protected Vector3 toVector3;

		protected float duration;

		protected float delay;

		protected bool isDelaying;

		protected Action onCompletedAction;

		protected AnimationCurve easeCurve;

		protected Vector3 curVector3;

		protected float t
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public virtual void SetInfo(Vector3 _fromVector3, Vector3 _toVector3, float _duration, float _delay = 0f, AnimationCurve _easeCurve = null, Action _onCompletedAction = null)
		{
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

		public virtual void TimeUpdated()
		{
		}

		public void Reset()
		{
		}

		public override void Pause(bool isPause)
		{
		}
	}
}
