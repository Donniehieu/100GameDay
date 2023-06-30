using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BigBear.Core.Runtime.Pool
{
	[Serializable]
	public class FastPool
	{
		[CompilerGenerated]
		private sealed class _003CCoClearCache_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FastPool _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoClearCache_003Ed__28(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[SerializeField]
		[Tooltip("Prefab that would be used as source")]
		private GameObject sourcePrefab;

		[Tooltip("Cache size (maximum amount of the cached items).\r\n[0 - unlimited]")]
		public int Capacity;

		[Tooltip("How much items must be cached at the start")]
		public int PreloadCount;

		[Tooltip("How to call events OnFastInstantiate and OnFastDestroy. Note, that if use choose notification via Interface, you must implement IFastPoolItem in any script on your sourcePrefab")]
		public PoolItemNotificationType NotificationType;

		[Tooltip("Load source prefab in the memory while scene is loading. A bit slower scene loading, but faster instantiating of new objects in pool")]
		public bool WarmOnLoad;

		[Tooltip("Parent cached objects to FastPoolManager game object.\r\n[WARNING] Turning this option on will make objects cached a bit slower.")]
		public bool ParentOnCache;

		[Tooltip("Use custom pool ID. By default it equals to the InstanceID of the source prefab.\r\n[WARNING] Be careful with this option.")]
		[SerializeField]
		private bool useCustomID;

		[HideInInspector]
		[SerializeField]
		private int customID;

		[HideInInspector]
		[SerializeField]
		private int cached_internal;

		private Stack<GameObject> cache;

		private Transform parentTransform;

		private WaitForEndOfFrame waitEndFrame;

		public int ID
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Name => null;

		public int Cached => 0;

		public bool IsValid
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FastPool(GameObject prefab, Transform rootTransform = null, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0)
		{
		}

		public FastPool(int id, GameObject prefab, Transform rootTransform = null, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0)
		{
		}

		public bool Init(Transform rootTransform)
		{
			return false;
		}

		public void ClearCache()
		{
		}

		[IteratorStateMachine(typeof(_003CCoClearCache_003Ed__28))]
		public IEnumerator CoClearCache()
		{
			return null;
		}

		public T FastInstantiate<T>(Transform parent = null) where T : Component
		{
			return null;
		}

		public T FastInstantiate<T>(Vector3 position, Quaternion rotation, Transform parent = null) where T : Component
		{
			return null;
		}

		public GameObject FastInstantiate(Transform parent = null)
		{
			return null;
		}

		public GameObject FastInstantiate(Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		public void FastDestroy<T>(T sceneObject) where T : Component
		{
		}

		public void FastDestroy(GameObject sceneObject)
		{
		}

		private GameObject MakeClone(Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}
	}
}
