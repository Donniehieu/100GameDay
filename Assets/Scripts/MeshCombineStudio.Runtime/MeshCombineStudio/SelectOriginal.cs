using UnityEngine;

namespace MeshCombineStudio
{
	public class SelectOriginal : MonoBehaviour
	{
		public MeshCombiner meshCombiner;

		public Camera mainCamera;

		public Material matSelect;

		private Material oldMat;

		private Vector3 oldPos;

		private MeshRenderer oldMr;

		private void Update()
		{
		}

		private void Deselect()
		{
		}

		private void SelectOrDeselect(Vector3 position, MeshRenderer mr, Material mat, bool select)
		{
		}
	}
}
