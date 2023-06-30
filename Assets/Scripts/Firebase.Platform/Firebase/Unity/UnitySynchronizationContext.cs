using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Scripting;

namespace Firebase.Unity
{
	[Preserve]
	internal class UnitySynchronizationContext : SynchronizationContext
	{
		private class SynchronizationContextBehavoir : MonoBehaviour
		{
			[CompilerGenerated]
			private sealed class _003CStart_003Ed__3 : IEnumerator<object>, IDisposable, IEnumerator
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public SynchronizationContextBehavoir _003C_003E4__this;

				private Tuple<SendOrPostCallback, object> _003Centry_003E5__1;

				private Queue<Tuple<SendOrPostCallback, object>> _003C_003Es__2;

				private bool _003C_003Es__3;

				private Exception _003Ce_003E5__4;

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
				public _003CStart_003Ed__3(int _003C_003E1__state)
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

			private Queue<Tuple<SendOrPostCallback, object>> callbackQueue;

			public Queue<Tuple<SendOrPostCallback, object>> CallbackQueue => null;

			[Preserve]
			[IteratorStateMachine(typeof(_003CStart_003Ed__3))]
			private IEnumerator Start()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSignaledCoroutine_003Ed__13 : IEnumerator<object>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Func<IEnumerator> coroutine;

			public ManualResetEvent newSignal;

			public UnitySynchronizationContext _003C_003E4__this;

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
			public _003CSignaledCoroutine_003Ed__13(int _003C_003E1__state)
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

		private static UnitySynchronizationContext _instance;

		private Queue<Tuple<SendOrPostCallback, object>> queue;

		private SynchronizationContextBehavoir behavior;

		private int mainThreadId;

		private const int Timeout = 15000;

		private static Dictionary<int, ManualResetEvent> signalDictionary;

		public static UnitySynchronizationContext Instance => null;

		private UnitySynchronizationContext(GameObject gameObject)
		{
		}

		public static void Create(GameObject gameObject)
		{
		}

		public static void Destroy()
		{
		}

		private ManualResetEvent GetThreadEvent()
		{
			return null;
		}

		public void PostCoroutine(Func<IEnumerator> coroutine)
		{
		}

		[IteratorStateMachine(typeof(_003CSignaledCoroutine_003Ed__13))]
		private IEnumerator SignaledCoroutine(Func<IEnumerator> coroutine, ManualResetEvent newSignal)
		{
			return null;
		}

		public void SendCoroutine(Func<IEnumerator> coroutine, int timeout = 15000)
		{
		}

		public override void Post(SendOrPostCallback d, object state)
		{
		}

		public override void Send(SendOrPostCallback d, object state)
		{
		}
	}
}
