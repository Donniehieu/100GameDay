using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	internal class DebugUpdater : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoAfterInputModuleUpdated_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action action;

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
			public _003CDoAfterInputModuleUpdated_003Ed__9(int _003C_003E1__state)
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
		private sealed class _003CRefreshRuntimeUINextFrame_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CRefreshRuntimeUINextFrame_003Ed__15(int _003C_003E1__state)
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

		private static DebugUpdater s_Instance;

		private ScreenOrientation m_Orientation;

		private bool m_RuntimeUiWasVisibleLastFrame;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void RuntimeInit()
		{
		}

		internal static void SetEnabled(bool enabled)
		{
		}

		private static void EnableRuntime()
		{
		}

		private static void DisableRuntime()
		{
		}

		internal static void HandleInternalEventSystemComponents(bool uiEnabled)
		{
		}

		private void EnsureExactlyOneEventSystem()
		{
		}

		[IteratorStateMachine(typeof(_003CDoAfterInputModuleUpdated_003Ed__9))]
		private IEnumerator DoAfterInputModuleUpdated(Action action)
		{
			return null;
		}

		private void CheckInputModuleExists()
		{
		}

		private void AssignDefaultActions()
		{
		}

		private void CreateDebugEventSystem()
		{
		}

		private void DestroyDebugEventSystem()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CRefreshRuntimeUINextFrame_003Ed__15))]
		private static IEnumerator RefreshRuntimeUINextFrame()
		{
			return null;
		}
	}
}
