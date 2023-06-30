using System;
using DG.Tweening;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class MoveLoop
	{
		public bool enabled;

		public Vector3 movement;

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

		public MoveLoop Copy()
		{
			return null;
		}
	}
}
