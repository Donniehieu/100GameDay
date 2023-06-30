using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SRF.Service
{
	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService where T : class where TImpl : Component
	{
		[CompilerGenerated]
		private sealed class _003CLoadCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SRSceneServiceBase<T, TImpl> _003C_003E4__this;

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
			public _003CLoadCoroutine_003Ed__11(int _003C_003E1__state)
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

		private TImpl _rootObject;

		protected abstract string SceneName { get; }

		protected TImpl RootObject => null;

		public bool IsLoaded => false;

		[Conditional("ENABLE_LOGGING")]
		private void Log(string msg, UnityEngine.Object target)
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected virtual void OnLoaded()
		{
		}

		[IteratorStateMachine(typeof(SRSceneServiceBase<, >._003CLoadCoroutine_003Ed__11))]
		private IEnumerator LoadCoroutine()
		{
			return null;
		}

		protected SRSceneServiceBase()
		{
			((SRServiceBase<>)(object)this)._002Ector();
		}
	}
}
