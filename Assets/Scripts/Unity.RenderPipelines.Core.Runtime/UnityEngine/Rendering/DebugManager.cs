using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.UI;

namespace UnityEngine.Rendering
{
	public sealed class DebugManager
	{
		private const string kEnableDebugBtn1 = "Enable Debug Button 1";

		private const string kEnableDebugBtn2 = "Enable Debug Button 2";

		private const string kDebugPreviousBtn = "Debug Previous";

		private const string kDebugNextBtn = "Debug Next";

		private const string kValidateBtn = "Debug Validate";

		private const string kPersistentBtn = "Debug Persistent";

		private const string kDPadVertical = "Debug Vertical";

		private const string kDPadHorizontal = "Debug Horizontal";

		private const string kMultiplierBtn = "Debug Multiplier";

		private const string kResetBtn = "Debug Reset";

		private const string kEnableDebug = "Enable Debug";

		private DebugActionDesc[] m_DebugActions;

		private DebugActionState[] m_DebugActionStates;

		private InputActionMap debugActionMap;

		private static readonly Lazy<DebugManager> s_Instance;

		private ReadOnlyCollection<DebugUI.Panel> m_ReadOnlyPanels;

		private readonly List<DebugUI.Panel> m_Panels;

		public bool refreshEditorRequested;

		private int? m_RequestedPanelIndex;

		private GameObject m_Root;

		private DebugUIHandlerCanvas m_RootUICanvas;

		private GameObject m_PersistentRoot;

		private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas;

		private bool m_EditorOpen;

		private bool m_EnableRuntimeUI;

		public static DebugManager instance => null;

		public ReadOnlyCollection<DebugUI.Panel> panels => null;

		public bool displayEditorUI => false;

		public bool enableRuntimeUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool displayRuntimeUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool displayPersistentRuntimeUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<bool> onDisplayRuntimeUIChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onSetDirty
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private event Action resetData
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void RegisterActions()
		{
		}

		internal void EnableInputActions()
		{
		}

		private void AddAction(DebugAction action, DebugActionDesc desc)
		{
		}

		private void SampleAction(int actionIndex)
		{
		}

		private void UpdateAction(int actionIndex)
		{
		}

		internal void UpdateActions()
		{
		}

		internal float GetAction(DebugAction action)
		{
			return 0f;
		}

		internal bool GetActionToggleDebugMenuWithTouch()
		{
			return false;
		}

		internal bool GetActionReleaseScrollTarget()
		{
			return false;
		}

		private void RegisterInputs()
		{
		}

		private void UpdateReadOnlyCollection()
		{
		}

		public void ToggleEditorUI(bool open)
		{
		}

		private DebugManager()
		{
		}

		public void RefreshEditor()
		{
		}

		public void Reset()
		{
		}

		public void ReDrawOnScreenDebug()
		{
		}

		public void RegisterData(IDebugData data)
		{
		}

		public void UnregisterData(IDebugData data)
		{
		}

		public int GetState()
		{
			return 0;
		}

		internal void RegisterRootCanvas(DebugUIHandlerCanvas root)
		{
		}

		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext)
		{
		}

		internal void SetScrollTarget(DebugUIHandlerWidget widget)
		{
		}

		private void EnsurePersistentCanvas()
		{
		}

		internal void TogglePersistent(DebugUI.Widget widget)
		{
		}

		private void OnPanelDirty(DebugUI.Panel panel)
		{
		}

		public void RequestEditorWindowPanelIndex(int index)
		{
		}

		internal int? GetRequestedEditorWindowPanelIndex()
		{
			return null;
		}

		public DebugUI.Panel GetPanel(string displayName, bool createIfNull = false, int groupIndex = 0, bool overrideIfExist = false)
		{
			return null;
		}

		public void RemovePanel(string displayName)
		{
		}

		public void RemovePanel(DebugUI.Panel panel)
		{
		}

		public DebugUI.Widget GetItem(string queryPath)
		{
			return null;
		}

		private DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container)
		{
			return null;
		}
	}
}
