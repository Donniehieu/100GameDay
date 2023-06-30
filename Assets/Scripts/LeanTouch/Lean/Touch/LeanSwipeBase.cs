using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	public abstract class LeanSwipeBase : MonoBehaviour
	{
		public enum ModifyType
		{
			None = 0,
			Normalize = 1,
			Normalize4 = 2
		}

		public enum CoordinateType
		{
			ScaledPixels = 0,
			ScreenPixels = 1,
			ScreenPercentage = 2
		}

		[Serializable]
		public class LeanFingerEvent : UnityEvent<LeanFinger>
		{
			public LeanFingerEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Serializable]
		public class FloatEvent : UnityEvent<float>
		{
			public FloatEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Serializable]
		public class Vector2Event : UnityEvent<Vector2>
		{
			public Vector2Event()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Serializable]
		public class Vector3Event : UnityEvent<Vector3>
		{
			public Vector3Event()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Serializable]
		public class Vector3Vector3Event : UnityEvent<Vector3, Vector3>
		{
			public Vector3Vector3Event()
			{
				((UnityEvent<T0, T1>)(object)this)._002Ector();
			}
		}

		[FormerlySerializedAs("Angle")]
		public float RequiredAngle;

		[FormerlySerializedAs("AngleThreshold")]
		public float RequiredArc;

		[FormerlySerializedAs("onSwipe")]
		[FormerlySerializedAs("OnSwipe")]
		[SerializeField]
		public LeanFingerEvent onFinger;

		[FormerlySerializedAs("Clamp")]
		public ModifyType Modify;

		public CoordinateType Coordinate;

		public float Multiplier;

		[FormerlySerializedAs("OnSwipeDelta")]
		[SerializeField]
		[FormerlySerializedAs("onSwipeDelta")]
		public Vector2Event onDelta;

		[SerializeField]
		public FloatEvent onDistance;

		public LeanScreenDepth ScreenDepth;

		[SerializeField]
		public Vector3Event onWorldFrom;

		[SerializeField]
		public Vector3Event onWorldTo;

		[SerializeField]
		public Vector3Event onWorldDelta;

		[SerializeField]
		[FormerlySerializedAs("onSwipeFromTo")]
		public Vector3Vector3Event onWorldFromTo;

		public LeanFingerEvent OnFinger => null;

		public Vector2Event OnDelta => null;

		public FloatEvent OnDistance => null;

		public Vector3Event OnWorldFrom => null;

		public Vector3Event OnWorldTo => null;

		public Vector3Event OnWorldDelta => null;

		public Vector3Vector3Event OnWorldFromTo => null;

		protected bool AngleIsValid(Vector2 vector)
		{
			return false;
		}

		protected void HandleFingerSwipe(LeanFinger finger, Vector2 screenFrom, Vector2 screenTo)
		{
		}
	}
}
