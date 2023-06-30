using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.Services;
using SRF.Service;
using UnityEngine;
using UnityEngine.Rendering;

namespace SRDebugger.Profiler
{
	public class SRPProfilerService : SRServiceBase<IProfilerService>, IProfilerService
	{
		[CompilerGenerated]
		private sealed class _003CEndOfFrameCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SRPProfilerService _003C_003E4__this;

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
			public _003CEndOfFrameCoroutine_003Ed__19(int _003C_003E1__state)
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

		private const int FrameBufferSize = 400;

		private readonly CircularBuffer<ProfilerFrame> _frameBuffer;

		private ProfilerLateUpdateListener _lateUpdateListener;

		private double _updateDuration;

		private double _renderStartTime;

		private double _renderDuration;

		private readonly Stopwatch _stopwatch;

		public float AverageFrameTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float LastFrameTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CircularBuffer<ProfilerFrame> FrameBuffer => null;

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CEndOfFrameCoroutine_003Ed__19))]
		private IEnumerator EndOfFrameCoroutine()
		{
			return null;
		}

		protected void PushFrame(double totalTime, double updateTime, double renderTime)
		{
		}

		private void OnLateUpdate()
		{
		}

		private void RenderPipelineOnBeginFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		private void EndFrame()
		{
		}

		public SRPProfilerService()
		{
			((SRServiceBase<T>)(object)this)._002Ector();
		}
	}
}
