using UnityEngine;

namespace MeshCombineStudio
{
	public class CamGeometryCapture : MonoBehaviour
	{
		public ComputeShader computeDepthToArray;

		public Int2 resolution;

		public Camera cam;

		public Transform t;

		public RenderTexture rtCapture;

		private float[] heights;

		private Bounds bounds;

		private float maxSize;

		public void Init()
		{
		}

		private void OnDestroy()
		{
		}

		private void DisposeRenderTexture(ref RenderTexture rt)
		{
		}

		public void DisposeRTCapture()
		{
		}

		public void RemoveTrianglesBelowSurface(Transform t, MeshCombineJobManager.MeshCombineJob meshCombineJob, MeshCache.SubMeshCache newMeshCache, ref byte[] vertexIsBelow)
		{
		}

		public void Capture(Bounds bounds, int collisionMask, Vector3 direction, Int2 resolution)
		{
		}

		public void SetCamera(Vector3 direction)
		{
		}

		public float GetHeight(Vector3 pos)
		{
			return 0f;
		}
	}
}
