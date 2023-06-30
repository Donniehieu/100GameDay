using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Pathfinding.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Serializable]
	public class AstarData
	{
		[CompilerGenerated]
		private sealed class _003CFindGraphsOfType_003Ed__66 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public AstarData _003C_003E4__this;

			private Type type;

			public Type _003C_003E3__type;

			private int _003Ci_003E5__2;

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
			public _003CFindGraphsOfType_003Ed__66(int _003C_003E1__state)
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

			[DebuggerHidden]
			private IEnumerator<object> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EObject_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetUpdateableGraphs_003Ed__67 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public AstarData _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CGetUpdateableGraphs_003Ed__67(int _003C_003E1__state)
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

			[DebuggerHidden]
			private IEnumerator<object> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EObject_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetRaycastableGraphs_003Ed__68 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public AstarData _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CGetRaycastableGraphs_003Ed__68(int _003C_003E1__state)
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

			[DebuggerHidden]
			private IEnumerator<object> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EObject_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[NonSerialized]
		public NavGraph[] graphs;

		[SerializeField]
		private string dataString;

		[FormerlySerializedAs("data")]
		[SerializeField]
		private byte[] upgradeData;

		public TextAsset file_cachedStartup;

		public byte[] data_cachedStartup;

		[SerializeField]
		public bool cacheStartup;

		private List<bool> graphStructureLocked;

		public static AstarPath active => null;

		public NavMeshGraph navmesh
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

		public GridGraph gridGraph
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

		public LayerGridGraph layerGridGraph
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

		public PointGraph pointGraph
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

		public RecastGraph recastGraph
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

		public Type[] graphTypes
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

		private byte[] data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public byte[] GetData()
		{
			return null;
		}

		public void SetData(byte[] data)
		{
		}

		public void Awake()
		{
		}

		internal void LockGraphStructure(bool allowAddingGraphs = false)
		{
		}

		internal void UnlockGraphStructure()
		{
		}

		private PathProcessor.GraphUpdateLock AssertSafe(bool onlyAddingGraph = false)
		{
			return default(PathProcessor.GraphUpdateLock);
		}

		public void GetNodes(Action<GraphNode> callback)
		{
		}

		public void UpdateShortcuts()
		{
		}

		public void LoadFromCache()
		{
		}

		public byte[] SerializeGraphs()
		{
			return null;
		}

		public byte[] SerializeGraphs(SerializeSettings settings)
		{
			return null;
		}

		public byte[] SerializeGraphs(SerializeSettings settings, out uint checksum)
		{
			checksum = default(uint);
			return null;
		}

		public void DeserializeGraphs()
		{
		}

		private void ClearGraphs()
		{
		}

		public void OnDestroy()
		{
		}

		public void DeserializeGraphs(byte[] bytes)
		{
		}

		public void DeserializeGraphsAdditive(byte[] bytes)
		{
		}

		private void DeserializeGraphsPartAdditive(AstarSerializer sr)
		{
		}

		public void FindGraphTypes()
		{
		}

		[Obsolete("If really necessary. Use System.Type.GetType instead.")]
		public Type GetGraphType(string type)
		{
			return null;
		}

		[Obsolete("Use CreateGraph(System.Type) instead")]
		public NavGraph CreateGraph(string type)
		{
			return null;
		}

		internal NavGraph CreateGraph(Type type)
		{
			return null;
		}

		[Obsolete("Use AddGraph(System.Type) instead")]
		public NavGraph AddGraph(string type)
		{
			return null;
		}

		public NavGraph AddGraph(Type type)
		{
			return null;
		}

		private void AddGraph(NavGraph graph)
		{
		}

		public bool RemoveGraph(NavGraph graph)
		{
			return false;
		}

		public static NavGraph GetGraph(GraphNode node)
		{
			return null;
		}

		public NavGraph FindGraph(Func<NavGraph, bool> predicate)
		{
			return null;
		}

		public NavGraph FindGraphOfType(Type type)
		{
			return null;
		}

		public NavGraph FindGraphWhichInheritsFrom(Type type)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFindGraphsOfType_003Ed__66))]
		public IEnumerable FindGraphsOfType(Type type)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetUpdateableGraphs_003Ed__67))]
		public IEnumerable GetUpdateableGraphs()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetRaycastableGraphs_003Ed__68))]
		[Obsolete("Obsolete because it is not used by the package internally and the use cases are few. Iterate through the graphs array instead.")]
		public IEnumerable GetRaycastableGraphs()
		{
			return null;
		}

		public int GetGraphIndex(NavGraph graph)
		{
			return 0;
		}
	}
}
