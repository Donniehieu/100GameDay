using System;
using DG.Tweening;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class Rotate
	{
		public bool enabled;

		public Anim.AnimationType animationType;

		public Vector3 rotation;

		public RotateMode rotateMode;

		public UIAnimator.EaseType easeType;

		public Ease ease;

		public AnimationCurve animationCurve;

		public float startDelay;

		public float duration;

		public float TotalDuration => 0f;

		public Rotate(Anim.AnimationType aType)
		{
		}

		public void Reset(Anim.AnimationType aType)
		{
		}

		public void UpdateValues(Rotate r)
		{
		}

		public Rotate Copy()
		{
			return null;
		}

		public Rotate Reverse()
		{
			return null;
		}
	}
}
