using System;
using DG.Tweening;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class Move
	{
		public enum MoveDirection
		{
			Left = 0,
			Right = 1,
			Top = 2,
			Bottom = 3,
			TopLeft = 4,
			TopCenter = 5,
			TopRight = 6,
			MiddleLeft = 7,
			MiddleCenter = 8,
			MiddleRight = 9,
			BottomLeft = 10,
			BottomCenter = 11,
			BottomRight = 12,
			CustomPosition = 13
		}

		public bool enabled;

		public Anim.AnimationType animationType;

		public MoveDirection moveDirection;

		public Vector3 customPosition;

		public UIAnimator.EaseType easeType;

		public Ease ease;

		public AnimationCurve animationCurve;

		public float startDelay;

		public float duration;

		public float TotalDuration => 0f;

		public static MoveDirection Reverse(MoveDirection moveDirection)
		{
			return default(MoveDirection);
		}

		public Move(Anim.AnimationType aType)
		{
		}

		public void Reset(Anim.AnimationType aType, MoveDirection mDirection = MoveDirection.Left)
		{
		}

		public void UpdateValues(Move m)
		{
		}

		public Move Copy()
		{
			return null;
		}

		public Move Reverse()
		{
			return null;
		}
	}
}
