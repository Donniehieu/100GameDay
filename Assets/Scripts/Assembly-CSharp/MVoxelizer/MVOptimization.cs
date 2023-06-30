using System.Collections.Generic;
using UnityEngine;

namespace MVoxelizer
{
	public class MVOptimization
	{
		public MVTextureInfo tInfo;

		public Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceBack;

		public Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceForward;

		public Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceLeft;

		public Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceRight;

		public Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceUp;

		public Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceDown;

		public MVResult result;

		public MVGrid grid;

		public Mesh voxelMesh;

		public MVSlice CreateSlice(int v, MVVoxel voxel, Vector2 uvCoord)
		{
			return null;
		}

		public void OptimizeSlice(Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceDict, int lenX, int lenY)
		{
		}

		public void ComputeSlice(Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceDict)
		{
		}

		public void AddSliceVertices(Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceDict, Vector3 normal)
		{
		}

		public void AddSliceUVVoxel(Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceDict)
		{
		}

		public void AddSliceUVSource(Dictionary<int, Dictionary<MVInt2, MVSlice>> sliceDict)
		{
		}
	}
}
