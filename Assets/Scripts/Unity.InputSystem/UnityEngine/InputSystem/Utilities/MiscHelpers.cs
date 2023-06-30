using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Utilities
{
	internal static class MiscHelpers
	{
		[CompilerGenerated]
		private sealed class _003CEveryNth_003Ed__1<TValue> : IEnumerable<TValue>, IEnumerable, IEnumerator<TValue>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TValue _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<TValue> enumerable;

			public IEnumerable<TValue> _003C_003E3__enumerable;

			private int start;

			public int _003C_003E3__start;

			private int n;

			public int _003C_003E3__n;

			private int _003Cindex_003E5__2;

			private IEnumerator<TValue> _003C_003E7__wrap2;

			private TValue System_002ECollections_002EGeneric_002EIEnumerator_003CTValue_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(TValue);
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
			public _003CEveryNth_003Ed__1(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<TValue> System_002ECollections_002EGeneric_002EIEnumerable_003CTValue_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
		{
			return default(TValue);
		}

		[IteratorStateMachine(typeof(_003CEveryNth_003Ed__1<>))]
		public static IEnumerable<TValue> EveryNth<TValue>(this IEnumerable<TValue> enumerable, int n, int start = 0)
		{
			return null;
		}

		public static int IndexOf<TValue>(this IEnumerable<TValue> enumerable, TValue value)
		{
			return 0;
		}
	}
}
