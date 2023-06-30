using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Pathfinding.Util
{
	public class ParallelWorkQueue<T>
	{
		[CompilerGenerated]
		private sealed class _003CRun_003Ed__7 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public ParallelWorkQueue<T> _003C_003E4__this;

			private int progressTimeoutMillis;

			public int _003C_003E3__progressTimeoutMillis;

			private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CRun_003Ed__7(int _003C_003E1__state)
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

			[DebuggerHidden]
			private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		public Action<T, int> action;

		public readonly int threadCount;

		private readonly Queue<T> queue;

		private readonly int initialCount;

		private ManualResetEvent[] waitEvents;

		private Exception innerException;

		public ParallelWorkQueue(Queue<T> queue)
		{
		}

		[IteratorStateMachine(typeof(ParallelWorkQueue<>._003CRun_003Ed__7))]
		public IEnumerable<int> Run(int progressTimeoutMillis)
		{
			return null;
		}

		private void RunTask(int threadIndex)
		{
		}
	}
}
