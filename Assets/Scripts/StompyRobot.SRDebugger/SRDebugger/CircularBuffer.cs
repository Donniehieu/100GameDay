using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace SRDebugger
{
	[DefaultMember("Item")]
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T>
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__18 : IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public CircularBuffer<T> _003C_003E4__this;

			private ArraySegment<T>[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private ArraySegment<T> _003Csegment_003E5__4;

			private int _003Ci_003E5__5;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CGetEnumerator_003Ed__18(int _003C_003E1__state)
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

		private readonly T[] _buffer;

		private int _end;

		private int _count;

		private int _start;

		public int Capacity => 0;

		public bool IsFull => false;

		public bool IsEmpty => false;

		public int Count => 0;

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public CircularBuffer(int capacity)
		{
		}

		public CircularBuffer(int capacity, T[] items)
		{
		}

		public void Clear()
		{
		}

		[IteratorStateMachine(typeof(CircularBuffer<>._003CGetEnumerator_003Ed__18))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public T Front()
		{
			return default(T);
		}

		public T Back()
		{
			return default(T);
		}

		public void PushBack(T item)
		{
		}

		public void PushFront(T item)
		{
		}

		public void PopBack()
		{
		}

		public void PopFront()
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
		{
		}

		private void Increment(ref int index)
		{
		}

		private void Decrement(ref int index)
		{
		}

		private int InternalIndex(int index)
		{
			return 0;
		}

		private ArraySegment<T> ArrayOne()
		{
			return default(ArraySegment<T>);
		}

		private ArraySegment<T> ArrayTwo()
		{
			return default(ArraySegment<T>);
		}
	}
}
