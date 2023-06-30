using UnityEngine;

namespace MeshCombineStudio
{
	public class MeshFilterRevert : MonoBehaviour
	{
		public string guid;

		public string meshName;

		public bool DestroyAndReferenceMeshFilter(MeshFilter mf)
		{
			return false;
		}

		public void RevertMeshFilter(MeshFilter mf)
		{
		}
	}
}
