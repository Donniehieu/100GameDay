using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BigBear.Core.Runtime.Pool
{
	public class FastPoolManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoDestroyPoolSlowly_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FastPoolManager _003C_003E4__this;

			private Dictionary<int, FastPool>.Enumerator _003C_003E7__wrap1;

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
			public _003CCoDestroyPoolSlowly_003Ed__19(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[SerializeField]
		private List<FastPool> predefinedPools;

		private Dictionary<int, FastPool> pools;

		private Transform curTransform;

		public static FastPoolManager Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<int, FastPool> Pools => null;

		private void Awake()
		{
		}

		public static FastPool CreatePoolC<T>(T component, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0) where T : Component
		{
			return null;
		}

		public static FastPool CreatePool(GameObject prefab, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0)
		{
			return null;
		}

		public static FastPool CreatePool(int id, GameObject prefab, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0)
		{
			return null;
		}

		public static FastPool GetPool(GameObject prefab, bool createIfNotExists = true)
		{
			return null;
		}

		public static FastPool GetPool(GameObject prefab, int preloadCount, bool createIfNotExists = true)
		{
			return null;
		}

		public static void CreatPoolIfNotExisted(GameObject prefab, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0)
		{
		}

		public static FastPool GetPool(int id, GameObject prefab, bool createIfNotExists = true)
		{
			return null;
		}

		public static FastPool GetPool(Component component, bool createIfNotExists = true)
		{
			return null;
		}

		public static void DestroyPool(FastPool pool)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDestroyPoolSlowly_003Ed__19))]
		public IEnumerator CoDestroyPoolSlowly()
		{
			return null;
		}
	}
}
