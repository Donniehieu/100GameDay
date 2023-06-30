using UnityEngine;

namespace MeshCombineStudio
{
	public class SectorGrid3D<T>
	{
		public FastIndexList<Sector3D<T>> sectorList;

		public Sector3D<T>[,,] sectors;

		public Rect rect;

		public Int3 sectorCount;

		public Vector3 sectorGridOffset;

		public Vector3 sectorSize;

		public Vector3 halfSectorSize;

		public Vector3 invSectorSize;

		public Vector3 totalSize;

		public Vector3 halfTotalSize;

		public SectorGrid3D(Int3 sectorCount, Vector3 sectorSize, Vector3 sectorGridOffset)
		{
		}

		public void GetSectors(FastList<Sector3D<T>> list, Vector3 pos, float radius)
		{
		}

		public void GetOrCreateSector(Vector3 pos, out Sector3D<T> sector)
		{
			sector = null;
		}

		public Int3 GetSectorIndex(Vector3 pos)
		{
			return default(Int3);
		}

		public Sector3D<T> GetSector(Vector3 pos)
		{
			return null;
		}

		public Sector3D<T> CreateSector(ref Int3 s)
		{
			return null;
		}

		public void RemoveSector(Vector3 pos)
		{
		}

		public void RemoveSector(Int3 sectorIndex)
		{
		}

		public void Reset()
		{
		}

		public void Draw()
		{
		}

		public void DrawSectors(FastList<Sector3D<T>> sectors, Color color)
		{
		}
	}
}
