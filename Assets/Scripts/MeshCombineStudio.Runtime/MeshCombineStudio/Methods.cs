using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MeshCombineStudio
{
	public static class Methods
	{
		public static HideFlags CustomToHideFlags(CustomHideFlags customHideFlags)
		{
			return default(HideFlags);
		}

		public static CustomHideFlags HideFlagsToCustom(HideFlags hideFlags)
		{
			return default(CustomHideFlags);
		}

		public static int GetFirstLayerOfLayerMask(LayerMask layerMask)
		{
			return 0;
		}

		public static bool IsLayerInLayerMask(LayerMask layerMask, int layer)
		{
			return false;
		}

		public static void SetMeshRenderersActive(FastList<MeshRenderer> mrs, bool active)
		{
		}

		public static void SetCachedGOSActive(FastList<CachedGameObject> cachedGOS, bool active)
		{
		}

		public static void SetTag(GameObject go, string tag)
		{
		}

		public static void SetTagWhenCollider(GameObject go, string tag)
		{
		}

		public static void SetTagAndLayer(GameObject go, string tag, int layer)
		{
		}

		public static void SetLayer(GameObject go, int layer)
		{
		}

		public static bool LayerMaskContainsLayer(int layerMask, int layer)
		{
			return false;
		}

		public static int GetFirstLayerInLayerMask(int layerMask)
		{
			return 0;
		}

		public static bool Contains(string compare, string name)
		{
			return false;
		}

		public static T[] Search<T>(GameObject parentGO = null)
		{
			return null;
		}

		public static FastList<GameObject> GetAllRootGameObjects()
		{
			return null;
		}

		public static T[] SearchParent<T>(GameObject parentGO, bool searchInActiveGameObjects) where T : Component
		{
			return null;
		}

		public static T[] SearchScene<T>(Scene scene, bool searchInActiveGameObjects) where T : Component
		{
			return null;
		}

		public static FastList<T> SearchAllScenes<T>(bool searchInActiveGameObjects) where T : Component
		{
			return null;
		}

		public static T Find<T>(GameObject parentGO, string name) where T : Component
		{
			return null;
		}

		public static void SetCollidersActive(Collider[] colliders, bool active, string[] nameList)
		{
		}

		public static void SelectChildrenWithMeshRenderer(GameObject[] parentGOs)
		{
		}

		public static void SelectChildrenWithMeshRenderer(Transform t)
		{
		}

		public static void DestroyChildren(Transform t)
		{
		}

		public static void Destroy(GameObject go)
		{
		}

		public static void Destroy(Component c)
		{
		}

		public static void SetChildrenActive(Transform t, bool active)
		{
		}

		public static void SnapBoundsAndPreserveArea(ref Bounds bounds, float snapSize, Vector3 offset)
		{
		}

		public static void ListRemoveAt<T>(List<T> list, int index)
		{
		}

		public static void CopyComponent(Component component, GameObject target)
		{
		}

		public static Transform GetChildRootTransform(Transform t, Transform rootT)
		{
			return null;
		}
	}
}
