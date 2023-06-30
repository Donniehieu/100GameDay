using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.Services;
using SRF;
using SRF.UI.Layout;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ConsoleLogControl : SRMonoBehaviourEx
	{
		[CompilerGenerated]
		private sealed class _003CScrollToBottom_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConsoleLogControl _003C_003E4__this;

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
			public _003CScrollToBottom_003Ed__26(int _003C_003E1__state)
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

		[RequiredField]
		[SerializeField]
		private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;

		[RequiredField]
		[SerializeField]
		private ScrollRect _consoleScrollRect;

		private bool _isDirty;

		private Vector2? _scrollPosition;

		private bool _showErrors;

		private bool _showInfo;

		private bool _showWarnings;

		public Action<ConsoleEntry> SelectedItemChanged;

		private string _filter;

		public bool ShowErrors
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowWarnings
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableSelection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Filter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CScrollToBottom_003Ed__26))]
		private IEnumerator ScrollToBottom()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		private void OnSelectedItemChanged(object arg0)
		{
		}

		protected override void Update()
		{
		}

		private void Refresh()
		{
		}

		private void SetIsDirty()
		{
		}

		private void ConsoleOnUpdated(IConsoleService console)
		{
		}
	}
}
