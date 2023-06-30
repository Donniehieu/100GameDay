using UnityEngine;

namespace MeshCombineStudio
{
	[ExecuteInEditMode]
	public class ObjectSpawner : MonoBehaviour
	{
		public GameObject[] objects;

		public Vector3 spawnArea;

		public float density;

		public Vector2 scaleRange;

		public Vector3 rotationRange;

		public Vector2 heightRange;

		public float scaleMulti;

		public float metersBetweenSpawning;

		public bool spawnInRuntime;

		public bool spawn;

		public bool deleteChildren;

		private Transform t;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void DeleteChildren()
		{
		}

		private void SetObjectsActive(bool active)
		{
		}

		public void Spawn()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
