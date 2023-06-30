using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Preserve]
	[JsonOptIn]
	public class PointGraph : NavGraph, IUpdatableGraph
	{
		public enum NodeDistanceMode
		{
			Node = 0,
			Connection = 1
		}

		[CompilerGenerated]
		private sealed class _003CScanInternal_003Ed__35 : IEnumerable<Progress>, IEnumerable, IEnumerator<Progress>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Progress _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public PointGraph _003C_003E4__this;

			private GameObject[] _003Cgos_003E5__2;

			private IEnumerator<Progress> _003C_003E7__wrap2;

			private Progress System_002ECollections_002EGeneric_002EIEnumerator_003CPathfinding_002EProgress_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(Progress);
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
			public _003CScanInternal_003Ed__35(int _003C_003E1__state)
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

			[DebuggerHidden]
			private IEnumerator<Progress> System_002ECollections_002EGeneric_002EIEnumerable_003CPathfinding_002EProgress_003E_002EGetEnumerator()
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
		private sealed class _003CConnectNodesAsync_003Ed__37 : IEnumerable<Progress>, IEnumerable, IEnumerator<Progress>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Progress _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public PointGraph _003C_003E4__this;

			private List<Connection> _003Cconnections_003E5__2;

			private List<GraphNode> _003CcandidateConnections_003E5__3;

			private long _003CmaxSquaredRange_003E5__4;

			private int _003Ci_003E5__5;

			private Progress System_002ECollections_002EGeneric_002EIEnumerator_003CPathfinding_002EProgress_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(Progress);
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
			public _003CConnectNodesAsync_003Ed__37(int _003C_003E1__state)
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
			private IEnumerator<Progress> System_002ECollections_002EGeneric_002EIEnumerable_003CPathfinding_002EProgress_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[JsonMember]
		public Transform root;

		[JsonMember]
		public string searchTag;

		[JsonMember]
		public float maxDistance;

		[JsonMember]
		public Vector3 limits;

		[JsonMember]
		public bool raycast;

		[JsonMember]
		public bool use2DPhysics;

		[JsonMember]
		public bool thickRaycast;

		[JsonMember]
		public float thickRaycastRadius;

		[JsonMember]
		public bool recursive;

		[JsonMember]
		public LayerMask mask;

		[JsonMember]
		public bool optimizeForSparseGraph;

		private PointKDTree lookupTree;

		private long maximumConnectionLength;

		public PointNode[] nodes;

		[JsonMember]
		public NodeDistanceMode nearestNodeDistanceMode;

		public int nodeCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public override int CountNodes()
		{
			return 0;
		}

		public override void GetNodes(Action<GraphNode> action)
		{
		}

		public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfoInternal);
		}

		public override NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfoInternal);
		}

		private NNInfoInternal GetNearestInternal(Vector3 position, NNConstraint constraint, bool fastCheck)
		{
			return default(NNInfoInternal);
		}

		private NNInfoInternal FindClosestConnectionPoint(PointNode node, Vector3 position)
		{
			return default(NNInfoInternal);
		}

		public PointNode AddNode(Int3 position)
		{
			return null;
		}

		public T AddNode<T>(T node, Int3 position) where T : PointNode
		{
			return null;
		}

		protected static int CountChildren(Transform tr)
		{
			return 0;
		}

		protected void AddChildren(ref int c, Transform tr)
		{
		}

		public void RebuildNodeLookup()
		{
		}

		public void RebuildConnectionDistanceLookup()
		{
		}

		private void AddToLookup(PointNode node)
		{
		}

		public void RegisterConnectionLength(long sqrLength)
		{
		}

		protected virtual PointNode[] CreateNodes(int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CScanInternal_003Ed__35))]
		protected override IEnumerable<Progress> ScanInternal()
		{
			return null;
		}

		public void ConnectNodes()
		{
		}

		[IteratorStateMachine(typeof(_003CConnectNodesAsync_003Ed__37))]
		private IEnumerable<Progress> ConnectNodesAsync()
		{
			return null;
		}

		public virtual bool IsValidConnection(GraphNode a, GraphNode b, out float dist)
		{
			dist = default(float);
			return false;
		}

		private GraphUpdateThreading Pathfinding_002EIUpdatableGraph_002ECanUpdateAsync(GraphUpdateObject o)
		{
			return default(GraphUpdateThreading);
		}

		private void Pathfinding_002EIUpdatableGraph_002EUpdateAreaInit(GraphUpdateObject o)
		{
		}

		private void Pathfinding_002EIUpdatableGraph_002EUpdateAreaPost(GraphUpdateObject o)
		{
		}

		private void Pathfinding_002EIUpdatableGraph_002EUpdateArea(GraphUpdateObject guo)
		{
		}

		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		public override void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}

		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}
	}
}
