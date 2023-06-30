using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Finger Update")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanFingerUpdate")]
	public class LeanFingerUpdate : MonoBehaviour
	{
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

		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public bool IgnoreIfStatic;

		public bool IgnoreIfDown;

		public bool IgnoreIfUp;

		public LeanSelectable RequiredSelectable;

		[SerializeField]
		[FormerlySerializedAs("onDrag")]
		private LeanFingerEvent onFinger;

		public CoordinateType Coordinate;

		public float Multiplier;

		[FormerlySerializedAs("onDragDelta")]
		[SerializeField]
		private Vector2Event onDelta;

		[SerializeField]
		private FloatEvent onDistance;

		public LeanScreenDepth ScreenDepth;

		[SerializeField]
		private Vector3Event onWorldFrom;

		[SerializeField]
		private Vector3Event onWorldTo;

		[SerializeField]
		private Vector3Event onWorldDelta;

		[SerializeField]
		private Vector3Vector3Event onWorldFromTo;

		public LeanFingerEvent OnFinger => null;

		public Vector2Event OnDelta => null;

		public FloatEvent OnDistance => null;

		public Vector3Event OnWorldFrom => null;

		public Vector3Event OnWorldTo => null;

		public Vector3Event OnWorldDelta => null;

		public Vector3Vector3Event OnWorldFromTo => null;

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void HandleFingerUpdate(LeanFinger finger)
		{
		}
	}
}
