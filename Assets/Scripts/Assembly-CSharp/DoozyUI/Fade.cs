using System;
using DG.Tweening;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class Fade
	{
		public bool enabled;

		public Anim.AnimationType animationType;

		public float alpha;

		public UIAnimator.EaseType easeType;

		public Ease ease;

		public AnimationCurve animationCurve;

		public float startDelay;

		public float duration;

		public float TotalDuration => 0f;

		public Fade(Anim.AnimationType aType)
		{
		}

		public void Reset(Anim.AnimationType aType)
		{
		}

		public void UpdateValues(Fade f)
		{
		}

		public Fade Copy()
		{
			return null;
		}

		public Fade Reverse()
		{
			return null;
		}
	}
}
