using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pathfinding.Examples
{
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_turn_based_door.php")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(SingleNodeBlocker))]
	public class TurnBasedDoor : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitAndClose_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TurnBasedDoor _003C_003E4__this;

			private List<SingleNodeBlocker> _003Cselector_003E5__2;

			private GraphNode _003Cnode_003E5__3;

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
			public _003CWaitAndClose_003Ed__6(int _003C_003E1__state)
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

		private Animator animator;

		private SingleNodeBlocker blocker;

		private bool open;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void Close()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndClose_003Ed__6))]
		private IEnumerator WaitAndClose()
		{
			return null;
		}

		public void Open()
		{
		}

		public void Toggle()
		{
		}
	}
}
