using System;
using DG.Tweening;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class ScaleLoop
	{
		public static Vector3 DEFAULT_MIN;

		public static Vector3 DEFAULT_MAX;

		public bool enabled;

		public Vector3 min;

		public Vector3 max;

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

		public ScaleLoop Copy()
		{
			return null;
		}
	}
}
