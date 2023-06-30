using System;

namespace MeshCombineStudio
{
	[Serializable]
	public class SortedFastList<T> : FastList<T>
	{
		public new void RemoveAt(int index)
		{
		}

		public new void RemoveRange(int index, int endIndex)
		{
		}

		public SortedFastList()
		{
			((FastList<>)(object)this)._002Ector();
		}
	}
}
