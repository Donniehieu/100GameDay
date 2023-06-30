using System;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal struct BitArray : IDisposable
	{
		private NativeArray<uint> m_Mem;

		private int m_BitCount;

		private int m_IntCount;

		public BitArray(int bitCount, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public bool IsSet(int bitIndex)
		{
			return false;
		}

		public void Set(int bitIndex, bool val)
		{
		}
	}
}
