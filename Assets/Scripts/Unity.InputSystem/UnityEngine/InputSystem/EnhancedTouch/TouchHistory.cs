using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch
{
	[DefaultMember("Item")]
	public struct TouchHistory : IReadOnlyList<Touch>, IEnumerable<Touch>, IEnumerable, IReadOnlyCollection<Touch>
	{
		private class Enumerator : IEnumerator<Touch>, IEnumerator, IDisposable
		{
			private readonly TouchHistory m_Owner;

			private int m_Index;

			public Touch Current => default(Touch);

			private object System_002ECollections_002EIEnumerator_002ECurrent => null;

			internal Enumerator(TouchHistory owner)
			{
			}

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

		private readonly InputStateHistory<TouchState> m_History;

		private readonly Finger m_Finger;

		private readonly int m_Count;

		private readonly int m_StartIndex;

		private readonly uint m_Version;

		public int Count => 0;

		public Touch Item => default(Touch);

		internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1, int count = -1)
		{
		}

		public IEnumerator<Touch> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		internal void CheckValid()
		{
		}
	}
}
