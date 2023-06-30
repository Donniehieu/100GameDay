using System;
using DG.Tweening;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class RotateLoop
	{
		public bool enabled;

		public Vector3 rotation;

		public UIAnimator.EaseType easeType;

		public Ease ease;

		public AnimationCurve animationCurve;

		public int loops;

		public Loop.LoopType loopType;

		public Loop.RotateMode rotateMode;

		public float startDelay;

		public float duration;

		public float TotalDuration => 0f;

		public void Reset()
		{
		}

		public RotateLoop Copy()
		{
			return null;
		}
	}
}
