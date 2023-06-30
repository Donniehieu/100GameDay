using UnityEngine;

namespace MVoxelizer
{
	[ExecuteInEditMode]
	public class VoxelGroup : MonoBehaviour
	{
		public Mesh voxelMesh;

		public Material[] voxelMaterials;

		public Material centerMaterial;

		public UVConversion uvType;

		public Vector3 voxelScale;

		public Vector3 voxelRotation;

		[HideInInspector]
		public float ratio;

		[HideInInspector]
		public Voxel[] voxels;

		[HideInInspector]
		public Vector3[] voxelPosition;

		[HideInInspector]
		public Vector2[] uvs;

		[HideInInspector]
		public int[] submesh;

		[HideInInspector]
		public GameObject[] centerVoxels;

		[HideInInspector]
		public Vector3[] centerVoxelPosition;

		private Mesh m_mesh;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void RebuildVoxels()
		{
		}

		public void ResetVoxels()
		{
		}

		public void CreateVoxel(int i)
		{
		}

		public void CreateCenterVoxel(int i)
		{
		}

		private void UpdateVoxel()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
