using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pathfinding
{
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_procedural_grid_mover.php")]
	public class ProceduralGridMover : VersionedMonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateGraphCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProceduralGridMover _003C_003E4__this;

			private Int2 _003Coffset_003E5__2;

			private int _003Cwidth_003E5__3;

			private int _003Cdepth_003E5__4;

			private GridNodeBase[] _003Cnodes_003E5__5;

			private int _003Clayers_003E5__6;

			private IntRect _003CrecalculateRect_003E5__7;

			private IntRect _003CconnectionRect_003E5__8;

			private int _003CyieldEvery_003E5__9;

			private int _003Ccounter_003E5__10;

			private int _003Cl_003E5__11;

			private int _003ClayerOffset_003E5__12;

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
			public _003CUpdateGraphCoroutine_003Ed__13(int _003C_003E1__state)
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

		public float updateDistance;

		public Transform target;

		private GridNodeBase[] buffer;

		public GridGraph graph;

		[HideInInspector]
		public int graphIndex;

		public bool updatingGraph
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

		private void Start()
		{
		}

		private void Update()
		{
		}

		private Vector3 PointToGraphSpace(Vector3 p)
		{
			return default(Vector3);
		}

		public void UpdateGraph()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateGraphCoroutine_003Ed__13))]
		private IEnumerator UpdateGraphCoroutine()
		{
			return null;
		}
	}
}
