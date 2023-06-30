using System;

namespace MeshCombineStudio
{
	[Serializable]
	public class FastList<T> : FastListBase<T>
	{
		public FastList()
		{
			((FastListBase<>)(object)this)._002Ector();
		}

		public FastList(bool reserve, int reserved)
		{
			((FastListBase<>)(object)this)._002Ector();
		}

		public FastList(int capacity)
		{
			((FastListBase<>)(object)this)._002Ector();
		}

		public FastList(FastList<T> list)
		{
			((FastListBase<>)(object)this)._002Ector();
		}

		public FastList(T[] items)
		{
			((FastListBase<>)(object)this)._002Ector();
		}

		protected void SetCapacity(int capacity)
		{
		}

		public void SetCount(int count)
		{
		}

		public void EnsureCount(int count)
		{
		}

		public virtual void SetArray(T[] items)
		{
		}

		public int AddUnique(T item)
		{
			return 0;
		}

		public bool Contains(T item)
		{
			return false;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public T GetIndex(T item)
		{
			return default(T);
		}

		public virtual int Add(T item)
		{
			return 0;
		}

		public virtual int AddThreadSafe(T item)
		{
			return 0;
		}

		public virtual void Add(T item, T item2)
		{
		}

		public virtual void Add(T item, T item2, T item3)
		{
		}

		public virtual void Add(T item, T item2, T item3, T item4)
		{
		}

		public virtual void Add(T item, T item2, T item3, T item4, T item5)
		{
		}

		public virtual void Insert(int index, T item)
		{
		}

		public virtual void AddRange(T[] arrayItems)
		{
		}

		public virtual void AddRange(T[] arrayItems, int startIndex, int length)
		{
		}

		public virtual void AddRange(FastList<T> list)
		{
		}

		public virtual int GrabListThreadSafe(FastList<T> threadList, bool fastClear = false)
		{
			return 0;
		}

		public virtual void ChangeRange(int startIndex, T[] arrayItems)
		{
		}

		public virtual bool Remove(T item, bool weakReference = false)
		{
			return false;
		}

		public virtual void RemoveAt(int index)
		{
		}

		public virtual void RemoveLast()
		{
		}

		public virtual void RemoveRange(int index, int length)
		{
		}

		public virtual T Dequeue()
		{
			return default(T);
		}

		public virtual T Dequeue(int index)
		{
			return default(T);
		}

		public virtual void Clear()
		{
		}

		public virtual void ClearThreadSafe()
		{
		}

		public virtual void ClearRange(int startIndex)
		{
		}

		public virtual void FastClear()
		{
		}

		public virtual void FastClear(int newCount)
		{
		}

		public virtual T[] ToArray()
		{
			return null;
		}
	}
}
