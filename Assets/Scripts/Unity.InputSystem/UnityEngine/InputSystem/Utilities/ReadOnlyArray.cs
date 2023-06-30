using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.InputSystem.Utilities
{
	[DefaultMember("Item")]
	public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue>
	{
		public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			private readonly TValue[] m_Array;

			private readonly int m_IndexStart;

			private readonly int m_IndexEnd;

			private int m_Index;

			public TValue Current => default(TValue);

			private object System_002ECollections_002EIEnumerator_002ECurrent => null;

			internal Enumerator(TValue[] array, int index, int length)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		internal TValue[] m_Array;

		internal int m_StartIndex;

		internal int m_Length;

		public int Count => 0;

		public TValue Item => default(TValue);

		public ReadOnlyArray(TValue[] array)
		{
		}

		public ReadOnlyArray(TValue[] array, int index, int length)
		{
		}

		public TValue[] ToArray()
		{
			return null;
		}

		public int IndexOf(Predicate<TValue> predicate)
		{
			return 0;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		private IEnumerator<TValue> System_002ECollections_002EGeneric_002EIEnumerable_003CTValue_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public static implicit operator ReadOnlyArray<TValue>(TValue[] array)
		{
			return default(ReadOnlyArray<TValue>);
		}
	}
}
