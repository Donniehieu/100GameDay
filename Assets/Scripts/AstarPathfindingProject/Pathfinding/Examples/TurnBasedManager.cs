using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Pathfinding.Examples
{
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_turn_based_manager.php")]
	public class TurnBasedManager : MonoBehaviour
	{
		public enum State
		{
			SelectUnit = 0,
			SelectTarget = 1,
			Move = 2
		}

		[CompilerGenerated]
		private sealed class _003CMoveToNode_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TurnBasedAI unit;

			public GraphNode node;

			public TurnBasedManager _003C_003E4__this;

			private ABPath _003Cpath_003E5__2;

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
			public _003CMoveToNode_003Ed__13(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CMoveAlongPath_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ABPath path;

			public TurnBasedAI unit;

			public float speed;

			private float _003CdistanceAlongSegment_003E5__2;

			private int _003Ci_003E5__3;

			private Vector3 _003Cp0_003E5__4;

			private Vector3 _003Cp1_003E5__5;

			private Vector3 _003Cp2_003E5__6;

			private Vector3 _003Cp3_003E5__7;

			private float _003CsegmentLength_003E5__8;

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
			public _003CMoveAlongPath_003Ed__14(int _003C_003E1__state)
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

		private TurnBasedAI selected;

		public float movementSpeed;

		public GameObject nodePrefab;

		public LayerMask layerMask;

		private List<GameObject> possibleMoves;

		private EventSystem eventSystem;

		public State state;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void HandleButtonUnderRay(Ray ray)
		{
		}

		private T GetByRay<T>(Ray ray) where T : class
		{
			return null;
		}

		private void Select(TurnBasedAI unit)
		{
		}

		[IteratorStateMachine(typeof(_003CMoveToNode_003Ed__13))]
		private IEnumerator MoveToNode(TurnBasedAI unit, GraphNode node)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMoveAlongPath_003Ed__14))]
		private static IEnumerator MoveAlongPath(TurnBasedAI unit, ABPath path, float speed)
		{
			return null;
		}

		private void DestroyPossibleMoves()
		{
		}

		private void GeneratePossibleMoves(TurnBasedAI unit)
		{
		}
	}
}
