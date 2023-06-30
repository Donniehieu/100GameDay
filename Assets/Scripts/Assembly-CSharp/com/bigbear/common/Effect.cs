using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.bigbear.common
{
	public class Effect : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitToDestroy_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Effect _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitToDestroy_003Ed__18(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoWaitToDestroy_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Effect _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoWaitToDestroy_003Ed__19(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[SerializeField]
		protected ParticleSystem particleSystem;

		[SerializeField]
		protected bool clearParticle;

		[SerializeField]
		protected float waitToStopTime;

		[SerializeField]
		protected EffectType effectType;

		[SerializeField]
		protected bool seftDestroy;

		[SerializeField]
		protected float waitToDestroyTime;

		protected WaitForSeconds waitToStop;

		protected WaitForSeconds waitToDestroy;

		[SerializeField]
		private TrailRenderer trail;

		public bool isLoop;

		private Vector3 rootScale;

		public EffectType Type => default(EffectType);

		private void Awake()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		private void StopEmitting()
		{
		}

		public virtual void SetInfo(Vector3 upDir)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitToDestroy_003Ed__18))]
		public virtual IEnumerator WaitToDestroy()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoWaitToDestroy_003Ed__19))]
		private IEnumerator CoWaitToDestroy()
		{
			return null;
		}

		public void WaitAndDestroyEffect()
		{
		}

		public virtual void DestroyEffect()
		{
		}
	}
}
