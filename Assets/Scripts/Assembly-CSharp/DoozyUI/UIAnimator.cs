using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace DoozyUI
{
	public class UIAnimator
	{
		public enum EaseType
		{
			Ease = 0,
			AnimationCurve = 1
		}

		public enum TweenIdType
		{
			Move = 0,
			Rotate = 1,
			Scale = 2,
			Fade = 3
		}

		public enum TweenIdAnimation
		{
			In = 0,
			Out = 1,
			Loop = 2,
			Punch = 3,
			State = 4
		}

		public const float DEFAULT_DURATION = 0.5f;

		public const float DEFAULT_START_DELAY = 0f;

		public const Ease DEFAULT_EASE = Ease.Linear;

		public const int DEFAULT_LOOPS = -1;

		public const float DEFAULT_DURATION_ONCOMPLETE = 0.1f;

		public const float DEFAULT_DURATION_INIT_LOOP = 0.2f;

		public const float DEFAULT_DURATION_RESET_TARGET = 0.1f;

		public static bool isTimeScaleIndependent;

		public static Ease Reverse(Ease ease)
		{
			return default(Ease);
		}

		public static string GetTweenId(RectTransform target, TweenIdType idType, TweenIdAnimation idAnimation)
		{
			return null;
		}

		public static void ResetTarget(RectTransform target, Vector3 startPosition, Vector3 startRotation, Vector3 startScale, float startAlpha, bool instantAnimation = true)
		{
		}

		public static void Move(RectTransform target, Vector3 startPosition, Anim animation, UnityAction OnStart, UnityAction OnComplete, bool instantAnimation = false, bool forced = false)
		{
		}

		private static Vector3 GetTargetPosition(RectTransform target, Vector3 startPosition, Anim animation)
		{
			return default(Vector3);
		}

		public static void Rotate(RectTransform target, Vector3 startRotation, Anim animation, UnityAction OnStart, UnityAction OnComplete, bool instantAnimation = false, bool forced = false)
		{
		}

		public static void Scale(RectTransform target, Vector3 startScale, Anim animation, UnityAction OnStart, UnityAction OnComplete, bool instantAnimation = false, bool forced = false)
		{
		}

		public static void Fade(RectTransform target, float startAlpha, Anim animation, UnityAction OnStart, UnityAction OnComplete, bool instantAnimation = false, bool forced = false)
		{
		}

		public static void StopAnimations(RectTransform target, Anim.AnimationType aType)
		{
		}

		public static void LoopMove(RectTransform target, Vector3 startPosition, Loop loop, UnityAction OnStart, UnityAction OnComplete, string id = "", bool forced = false)
		{
		}

		public static void LoopRotate(RectTransform target, Vector3 startRotation, Loop loop, UnityAction OnStart, UnityAction OnComplete, string id = "", bool forced = false)
		{
		}

		public static void LoopScale(RectTransform target, Vector3 startScale, Loop loop, UnityAction OnStart, UnityAction OnComplete, string id = "", bool forced = false)
		{
		}

		public static void LoopFade(RectTransform target, float startAlpha, Loop loop, UnityAction OnStart, UnityAction OnComplete, string id = "", bool blocksRaycasts = false, bool forced = false)
		{
		}

		public static void SetupLoops(RectTransform target, Vector3 startPosition, Vector3 startRotation, Vector3 startScale, float startAlpha, Loop loop, UnityAction OnStartMoveLoop, UnityAction OnCompleteMoveLoop, UnityAction OnStartRotateLoop, UnityAction OnCompleteRotateLoop, UnityAction OnStartScaleLoop, UnityAction OnCompleteScaleLoop, UnityAction OnStartFadeLoop, UnityAction OnCompleteFadeLoop, string id = "", bool blocksRaycasts = false, bool forced = false)
		{
		}

		public static void PlayLoops(RectTransform target, string id = "")
		{
		}

		public static void StopLoops(RectTransform target, string id = "")
		{
		}

		public static void PunchMove(RectTransform target, Vector3 startPosition, Punch punch, UnityAction OnStart, UnityAction OnComplete, bool forced = false)
		{
		}

		public static void PunchRotate(RectTransform target, Vector3 startRotation, Punch punch, UnityAction OnStart, UnityAction OnComplete, bool forced = false)
		{
		}

		public static void PunchScale(RectTransform target, Vector3 startScale, Punch punch, UnityAction OnStart, UnityAction OnComplete, bool forced = false)
		{
		}
	}
}
