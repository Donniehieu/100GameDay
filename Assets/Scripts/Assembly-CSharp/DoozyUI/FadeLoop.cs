using System;
using DG.Tweening;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class FadeLoop
	{
		public static float DEFAULT_MIN;

		public static float DEFAULT_MAX;

		public bool enabled;

		public float min;

		public float max;

		public UIAnimator.EaseType easeType;

		public Ease ease;

		public AnimationCurve animationCurve;

		public int loops;

		public Loop.LoopType loopType;

		public float startDelay;

		public float duration;

		public float TotalDuration => 0f;

		public void Reset()
		{
		}

		public FadeLoop Copy()
		{
			return null;
		}
	}
}
