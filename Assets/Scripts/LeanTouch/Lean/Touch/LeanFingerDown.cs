using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Finger Down")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanFingerDown")]
	public class LeanFingerDown : MonoBehaviour
	{
		[Serializable]
		public class LeanFingerEvent : UnityEvent<LeanFinger>
		{
			public LeanFingerEvent()
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
		public class Vector2Event : UnityEvent<Vector2>
		{
			public Vector2Event()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		public bool IgnoreStartedOverGui;

		public LeanSelectable RequiredSelectable;

		[FormerlySerializedAs("onDown")]
		[FormerlySerializedAs("OnDown")]
		[SerializeField]
		private LeanFingerEvent onFinger;

		public LeanScreenDepth ScreenDepth;

		[FormerlySerializedAs("onPosition")]
		[SerializeField]
		private Vector3Event onWorld;

		[SerializeField]
		private Vector2Event onScreen;

		public LeanFingerEvent OnFinger => null;

		public Vector3Event OnWorld => null;

		public Vector2Event OnScreen => null;

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void HandleFingerDown(LeanFinger finger)
		{
		}
	}
}
