using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.InputSystem.Utilities
{
	[DefaultMember("Item")]
	internal struct OneOrMore<TValue, TList> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue> where TList : IReadOnlyList<TValue>
	{
		private class Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			internal int m_Index;

			internal OneOrMore<TValue, TList> m_List;

			public TValue Current => default(TValue);

			private object System_002ECollections_002EIEnumerator_002ECurrent => null;

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private readonly bool m_IsSingle;

		private readonly TValue m_Single;

		private readonly TList m_Multiple;

		public int Count => 0;

		public TValue Item => default(TValue);

		public OneOrMore(TValue single)
		{
		}

		public OneOrMore(TList multiple)
		{
		}

		public static implicit operator OneOrMore<TValue, TList>(TValue single)
		{
			return default(OneOrMore<TValue, TList>);
		}

		public static implicit operator OneOrMore<TValue, TList>(TList multiple)
		{
			return default(OneOrMore<TValue, TList>);
		}

		public IEnumerator<TValue> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
