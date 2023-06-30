using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Pathfinding.Poly2Tri
{
	[DefaultMember("Item")]
	public struct FixedArray3<T> : IEnumerable, IEnumerable<T> where T : class
	{
		public T _0;

		public T _1;

		public T _2;

		public T Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public bool Contains(T value)
		{
			return false;
		}

		public int IndexOf(T value)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void Clear(T value)
		{
		}

		[DebuggerHidden]
		private IEnumerable<T> Enumerate()
		{
			return null;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}
	}
}
