using UnityEngine;

namespace MeshCombineStudio
{
	public class BaseOctree
	{
		public class Cell
		{
			public Cell mainParent;

			public Cell parent;

			public bool[] cellsUsed;

			public Bounds bounds;

			public int cellIndex;

			public int cellCount;

			public int level;

			public int maxLevels;

			public Cell()
			{
			}

			public Cell(Vector3 position, Vector3 size, int maxLevels)
			{
			}

			public Cell(Cell parent, int cellIndex, Bounds bounds)
			{
			}

			public void SetCell(Cell parent, int cellIndex, Bounds bounds)
			{
			}

			protected int AddCell<T, U>(ref T[] cells, Vector3 position, out bool maxCellCreated) where T : Cell, new() where U : Cell, new()
			{
				maxCellCreated = default(bool);
				return 0;
			}

			protected T GetCell<T>(T[] cells, Vector3 position)
			{
				return default(T);
			}

			protected void AddCell<T, U>(ref T[] cells, int index, int x, int y, int z, out bool maxCellCreated) where T : Cell, new() where U : Cell, new()
			{
				maxCellCreated = default(bool);
			}

			public bool InsideBounds(Vector3 position)
			{
				return false;
			}

			public void Reset(ref Cell[] cells)
			{
			}
		}
	}
}
