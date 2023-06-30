using UnityEngine;

namespace BigBear.Core.Runtime.Pool
{
	public static class FastPoolExtensions
	{
		public static GameObject FastInstantiate(this GameObject sourcePrefab, Transform parentTransform = null)
		{
			return null;
		}

		public static GameObject FastInstantiate(this GameObject sourcePrefab, Vector3 position, Quaternion rotation, Transform parentTransform = null)
		{
			return null;
		}

		public static GameObject FastInstantiate(this GameObject sourcePrefab, int poolID, Transform parentTransform = null)
		{
			return null;
		}

		public static GameObject FastInstantiate(this GameObject sourcePrefab, int poolID, Vector3 position, Quaternion rotation, Transform parentTransform = null)
		{
			return null;
		}

		public static void FastDestroy(this GameObject objectToDestroy, GameObject sourcePrefab)
		{
		}

		public static void FastDestroy(this GameObject objectToDestroy, Component sourcePrefab)
		{
		}

		public static void FastDestroy(this GameObject objectToDestroy, FastPool pool)
		{
		}

		public static void FastDestroy(this GameObject objectToDestroy, int poolID)
		{
		}
	}
}
