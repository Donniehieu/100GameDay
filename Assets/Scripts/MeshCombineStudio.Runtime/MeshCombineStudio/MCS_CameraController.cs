using UnityEngine;

namespace MeshCombineStudio
{
	public class MCS_CameraController : MonoBehaviour
	{
		public float speed;

		public float mouseMoveSpeed;

		public float shiftMulti;

		public float controlMulti;

		private Vector3 oldMousePosition;

		private GameObject cameraMountGO;

		private GameObject cameraChildGO;

		private Transform cameraMountT;

		private Transform cameraChildT;

		private Transform t;

		private void Awake()
		{
		}

		private void CreateParents()
		{
		}

		private void Update()
		{
		}
	}
}
