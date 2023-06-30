using System.Collections.Generic;

namespace BigBear.Core.Runtime.Pool
{
	public class MemoryPool<T> where T : IPoolable, new()
	{
		private Stack<T> _items;

		private object _sync;

		public MemoryPool(int maxCount)
		{
		}

		public T Get()
		{
			return default(T);
		}

		public void Free(T item)
		{
		}
	}
}
