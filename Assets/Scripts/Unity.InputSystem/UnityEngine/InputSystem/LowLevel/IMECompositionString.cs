using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 132)]
	[DefaultMember("Item")]
	public struct IMECompositionString : IEnumerable<char>, IEnumerable
	{
		internal struct Enumerator : IEnumerator<char>, IEnumerator, IDisposable
		{
			private IMECompositionString m_CompositionString;

			private char m_CurrentCharacter;

			private int m_CurrentIndex;

			public char Current => '\0';

			private object System_002ECollections_002EIEnumerator_002ECurrent => null;

			public Enumerator(IMECompositionString compositionString)
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

		[FieldOffset(0)]
		private int size;

		[FieldOffset(4)]
		private unsafe fixed char buffer[64];

		public int Count => 0;

		public char Item => '\0';

		public IMECompositionString(string characters)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public IEnumerator<char> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
