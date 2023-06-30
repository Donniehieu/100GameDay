using System;
using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.Pool;
using UnityEngine;

namespace BigBear.Core.Runtime.Process
{
	public class SpriteFadeProcess : Process, IPoolable
	{
		protected SpriteRenderer spriteRenderer;

		protected float fromAlpha;

		protected float toAlpha;

		protected float duration;

		protected float delay;

		protected bool isDelaying;

		protected Action onCompletedAction;

		private Color curColor;

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

		public void SetInfo(SpriteRenderer _spriteRenderer, float _toAlpha, float _duration, float _delay = 0f, Action _onCompletedAction = null)
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

		public override void Pause(bool isPause)
		{
		}

		public void Reset()
		{
		}
	}
}
