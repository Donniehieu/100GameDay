namespace MeshCombineStudio
{
	public class FastIndexList<T> : FastList<T>, IFastIndexList where T : IFastIndex
	{
		public FastIndexList()
		{
			((FastList<>)(object)this)._002Ector();
		}

		public FastIndexList(int capacity)
		{
			((FastList<>)(object)this)._002Ector();
		}

		public new void Clear()
		{
		}

		public void SetItem(int index, T item)
		{
		}

		public new int Add(T item)
		{
			return 0;
		}

		public new void AddRange(T[] newItems)
		{
		}

		public new bool RemoveAt(int index)
		{
			return false;
		}

		public override T Dequeue()
		{
			return default(T);
		}

		public bool Remove(IFastIndex item)
		{
			return false;
		}
	}
}
