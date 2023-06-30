using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace Pathfinding
{
	public abstract class Path : IPathInternals
	{
		[CompilerGenerated]
		private sealed class _003CWaitForPath_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Path _003C_003E4__this;

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
			public _003CWaitForPath_003Ed__54(int _003C_003E1__state)
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

		protected PathHandler pathHandler;

		public OnPathDelegate callback;

		public OnPathDelegate immediateCallback;

		private object stateLock;

		public ITraversalProvider traversalProvider;

		protected PathCompleteState completeState;

		public List<GraphNode> path;

		public List<Vector3> vectorPath;

		protected PathNode currentR;

		public float duration;

		protected bool hasBeenReset;

		public NNConstraint nnConstraint;

		internal Path next;

		public Heuristic heuristic;

		public float heuristicScale;

		protected GraphNode hTargetNode;

		protected Int3 hTarget;

		public int enabledTags;

		private static readonly int[] ZeroTagPenalties;

		protected int[] internalTagPenalties;

		protected int[] manualTagPenalties;

		private List<object> claimed;

		private bool releasedNotSilent;

		public PathState PipelineState
		{
			[CompilerGenerated]
			get
			{
				return default(PathState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PathCompleteState CompleteState
		{
			get
			{
				return default(PathCompleteState);
			}
			protected set
			{
			}
		}

		public bool error => false;

		public string errorLog
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

		public int searchedNodes
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

		private bool Pathfinding_002EIPathInternals_002EPooled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Obsolete("Has been renamed to 'Pooled' to use more widely underestood terminology", true)]
		internal bool recycled => false;

		public ushort pathID
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

		public int[] tagPenalties
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool FloodingPath => false;

		private PathHandler Pathfinding_002EIPathInternals_002EPathHandler => null;

		public float GetTotalLength()
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CWaitForPath_003Ed__54))]
		public IEnumerator WaitForPath()
		{
			return null;
		}

		public void BlockUntilCalculated()
		{
		}

		internal uint CalculateHScore(GraphNode node)
		{
			return 0u;
		}

		public uint GetTagPenalty(int tag)
		{
			return 0u;
		}

		protected Int3 GetHTarget()
		{
			return default(Int3);
		}

		public bool CanTraverse(GraphNode node)
		{
			return false;
		}

		public uint GetTraversalCost(GraphNode node)
		{
			return 0u;
		}

		public virtual uint GetConnectionSpecialCost(GraphNode a, GraphNode b, uint currentCost)
		{
			return 0u;
		}

		public bool IsDone()
		{
			return false;
		}

		private void Pathfinding_002EIPathInternals_002EAdvanceState(PathState s)
		{
		}

		[Obsolete("Use the 'PipelineState' property instead")]
		public PathState GetState()
		{
			return default(PathState);
		}

		public void FailWithError(string msg)
		{
		}

		[Obsolete("Use FailWithError instead")]
		protected void LogError(string msg)
		{
		}

		[Obsolete("Use FailWithError instead")]
		protected void Log(string msg)
		{
		}

		public void Error()
		{
		}

		private void ErrorCheck()
		{
		}

		protected virtual void OnEnterPool()
		{
		}

		protected virtual void Reset()
		{
		}

		public void Claim(object o)
		{
		}

		[Obsolete("Use Release(o, true) instead")]
		internal void ReleaseSilent(object o)
		{
		}

		public void Release(object o, bool silent = false)
		{
		}

		protected virtual void Trace(PathNode from)
		{
		}

		protected void DebugStringPrefix(PathLog logMode, StringBuilder text)
		{
		}

		protected void DebugStringSuffix(PathLog logMode, StringBuilder text)
		{
		}

		protected virtual string DebugString(PathLog logMode)
		{
			return null;
		}

		protected virtual void ReturnPath()
		{
		}

		protected void PrepareBase(PathHandler pathHandler)
		{
		}

		protected abstract void Prepare();

		protected virtual void Cleanup()
		{
		}

		protected abstract void Initialize();

		protected abstract void CalculateStep(long targetTick);

		private void Pathfinding_002EIPathInternals_002EOnEnterPool()
		{
		}

		private void Pathfinding_002EIPathInternals_002EReset()
		{
		}

		private void Pathfinding_002EIPathInternals_002EReturnPath()
		{
		}

		private void Pathfinding_002EIPathInternals_002EPrepareBase(PathHandler handler)
		{
		}

		private void Pathfinding_002EIPathInternals_002EPrepare()
		{
		}

		private void Pathfinding_002EIPathInternals_002ECleanup()
		{
		}

		private void Pathfinding_002EIPathInternals_002EInitialize()
		{
		}

		private void Pathfinding_002EIPathInternals_002ECalculateStep(long targetTick)
		{
		}

		private string Pathfinding_002EIPathInternals_002EDebugString(PathLog logMode)
		{
			return null;
		}
	}
}
