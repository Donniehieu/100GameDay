using UnityEngine;

namespace MeshCombineStudio
{
	public class LODGroupSetup : MonoBehaviour
	{
		public MeshCombiner meshCombiner;

		public LODGroup lodGroup;

		public int lodGroupParentIndex;

		public int lodCount;

		private LODGroup[] lodGroups;

		public void Init(MeshCombiner meshCombiner, int lodGroupParentIndex)
		{
		}

		private void GetSetup()
		{
		}

		public void ApplySetup()
		{
		}

		public void AddLODGroupsToChildren()
		{
		}

		public void RemoveLODGroupFromChildren()
		{
		}
	}
}
