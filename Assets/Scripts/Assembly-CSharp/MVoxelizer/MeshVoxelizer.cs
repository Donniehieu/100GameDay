using System.Collections.Generic;
using UnityEngine;

namespace MVoxelizer
{
	public class MeshVoxelizer
	{
		public const int MAX_SUBDIVISION = 500;

		public const float SAMPLE_THRESHOLD = 0.05f;

		public const float APPROXIMATION_THRESHOLD = 0.9f;

		public GameObject sourceGameObject;

		public GenerationType generationType;

		public VoxelSizeType voxelSizeType;

		public int subdivisionLevel;

		public float absoluteVoxelSize;

		public Precision precision;

		public UVConversion uvConversion;

		public bool approximation;

		public bool ignoreScaling;

		public bool alphaCutout;

		public float CutoffValue;

		public bool modifyVoxel;

		public Mesh voxelMesh;

		public Vector3 voxelScale;

		public Vector3 voxelRotation;

		public bool boneWeightConversion;

		public bool backfaceCulling;

		public bool optimization;

		private bool instantiateResult;

		public FillCenterMethod fillCenter;

		public Material centerMaterial;

		protected MVSource m_source;

		protected MVGrid m_grid;

		protected MVResult m_result;

		protected MVOptimization m_opt;

		protected Dictionary<MVInt3, MVVoxel> voxelDict;

		public GameObject VoxelizeMesh(bool instantiateResult)
		{
			return null;
		}

		public virtual GameObject VoxelizeMesh()
		{
			return null;
		}

		private void Clear()
		{
		}

		protected virtual bool Initialization()
		{
			return false;
		}

		protected virtual bool AnalyzeMesh()
		{
			return false;
		}

		private void CheckTriangle(int index, int subMesh, float triangleStep)
		{
		}

		private void CheckPoint(Vector3 p, Vector3 ratio, int index, int subMesh, Vector3 normal)
		{
		}

		protected virtual bool ProcessVoxelData()
		{
			return false;
		}

		protected virtual bool FillCenterSpace(List<Vector3> centerVoxels)
		{
			return false;
		}

		protected virtual GameObject GenerateVoxels(List<Vector3> centerVoxels)
		{
			return null;
		}

		protected virtual bool CullFaces()
		{
			return false;
		}

		protected virtual bool GenerateMeshVerticesOpt()
		{
			return false;
		}

		protected virtual bool GenerateMeshVertices()
		{
			return false;
		}

		protected virtual bool DoOptimization()
		{
			return false;
		}

		protected virtual bool GenerateMeshUVsOpt()
		{
			return false;
		}

		protected virtual bool GenerateMeshUVs()
		{
			return false;
		}

		protected virtual bool GenerateMeshMaterialsOpt()
		{
			return false;
		}

		protected virtual bool GenerateMeshBoneWeights()
		{
			return false;
		}

		protected virtual GameObject GenerateResult()
		{
			return null;
		}

		protected virtual bool CancelProgress(string msg, float value)
		{
			return false;
		}
	}
}
