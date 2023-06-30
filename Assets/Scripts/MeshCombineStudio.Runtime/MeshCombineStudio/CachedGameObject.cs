using System;
using UnityEngine;

namespace MeshCombineStudio
{
	[Serializable]
	public class CachedGameObject
	{
		public Transform searchParentT;

		public GameObject go;

		public Transform t;

		public MeshRenderer mr;

		public MeshFilterRevert mfr;

		public MeshFilter mf;

		public Mesh mesh;

		public Matrix4x4 mt;

		public Matrix4x4 mtNormals;

		public Transform rootT;

		public Vector3 rootTLossyScale;

		public int rootInstanceId;

		public bool excludeCombine;

		public bool mrEnabled;

		public CachedGameObject(Transform searchParentT, GameObject go, Transform t, MeshRenderer mr, MeshFilter mf, Mesh mesh)
		{
		}

		public CachedGameObject(CachedComponents cachedComponent)
		{
		}

		public void GetRoot()
		{
		}
	}
}
