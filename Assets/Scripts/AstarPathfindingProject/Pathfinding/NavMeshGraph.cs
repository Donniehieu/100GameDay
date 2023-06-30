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
	[JsonOptIn]
	[Preserve]
	public class NavMeshGraph : NavmeshBase, IUpdatableGraph
	{
		[CompilerGenerated]
		private sealed class _003CScanInternal_003Ed__20 : IEnumerable<Progress>, IEnumerable, IEnumerator<Progress>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Progress _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public NavMeshGraph _003C_003E4__this;

			private List<Int3> _003CintVertices_003E5__2;

			private Int3[] _003CcompressedVertices_003E5__3;

			private int[] _003CcompressedTriangles_003E5__4;

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
			public _003CScanInternal_003Ed__20(int _003C_003E1__state)
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
		public Mesh sourceMesh;

		[JsonMember]
		public Vector3 offset;

		[JsonMember]
		public Vector3 rotation;

		[JsonMember]
		public float scale;

		[JsonMember]
		public bool recalculateNormals;

		[JsonMember]
		private Vector3 cachedSourceMeshBoundsMin;

		protected override bool RecalculateNormals => false;

		public override float TileWorldSizeX => 0f;

		public override float TileWorldSizeZ => 0f;

		protected override float MaxTileConnectionEdgeDistance => 0f;

		public override GraphTransform CalculateTransform()
		{
			return null;
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

		private void Pathfinding_002EIUpdatableGraph_002EUpdateArea(GraphUpdateObject o)
		{
		}

		public static void UpdateArea(GraphUpdateObject o, INavmeshHolder graph)
		{
		}

		[IteratorStateMachine(typeof(_003CScanInternal_003Ed__20))]
		protected override IEnumerable<Progress> ScanInternal()
		{
			return null;
		}

		protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}
	}
}
