using System;
using DG.Tweening;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class Scale
	{
		public bool enabled;

		public Anim.AnimationType animationType;

		public Vector3 scale;

		public UIAnimator.EaseType easeType;

		public Ease ease;

		public AnimationCurve animationCurve;

		public float startDelay;

		public float duration;

		public float TotalDuration => 0f;

		public Scale(Anim.AnimationType aType)
		{
		}

		public void Reset(Anim.AnimationType aType)
		{
		}

		public void UpdateValues(Scale s)
		{
		}

		public Scale Copy()
		{
			return null;
		}

		public Scale Reverse()
		{
			return null;
		}
	}
}
