using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanFingerOld")]
	[AddComponentMenu("Lean/Touch/Lean Finger Old")]
	public class LeanFingerOld : MonoBehaviour
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

		public bool IgnoreIsOverGui;

		public LeanSelectable RequiredSelectable;

		[SerializeField]
		private LeanFingerEvent onFinger;

		public LeanScreenDepth ScreenDepth;

		[SerializeField]
		[FormerlySerializedAs("onPosition")]
		private Vector3Event onWorld;

		[SerializeField]
		private Vector2Event onScreen;

		public LeanFingerEvent OnFinger => null;

		public Vector3Event OnWorld => null;

		public Vector2Event OnScreen => null;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void HandleFingerOld(LeanFinger finger)
		{
		}
	}
}
