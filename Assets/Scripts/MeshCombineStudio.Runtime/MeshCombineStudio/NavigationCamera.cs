using UnityEngine;

namespace MeshCombineStudio
{
	public class NavigationCamera : MonoBehaviour
	{
		public static float fov;

		public SO_NavigationCamera data;

		private Quaternion rot;

		private Vector3 currentSpeed;

		private float tStamp;

		private float deltaTime;

		private Vector3 startPosition;

		private Vector3 position;

		private Quaternion startRotation;

		private float scrollWheel;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void SetCam()
		{
		}

		public void RestoreCam()
		{
		}

		private float GetSpeedMulti()
		{
			return 0f;
		}

		private void Lerp2Way(ref Vector3 v, Vector3 targetV, float upMulti, float downMulti)
		{
		}

		private void Lerp2Way(ref float v, float targetV, float upMulti, float downMulti)
		{
		}
	}
}
