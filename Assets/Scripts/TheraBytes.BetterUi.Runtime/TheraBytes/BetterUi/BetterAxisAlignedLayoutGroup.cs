using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[ExecuteAlways]
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterAxisAlignedLayoutGroup.html")]
	[AddComponentMenu("Better UI/Layout/Better Axis Aligned Layout Group", 30)]
	public class BetterAxisAlignedLayoutGroup : HorizontalOrVerticalLayoutGroup, IBetterHorizontalOrVerticalLayoutGroup, IResolutionDependency
	{
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			public TextAnchor ChildAlignment;

			public bool ReverseArrangement;

			public bool ChildForceExpandHeight;

			public bool ChildForceExpandWidth;

			public bool ChildScaleWidth;

			public bool ChildScaleHeight;

			public bool ChildControlWidth;

			public bool ChildControlHeight;

			public Axis Orientation;

			[SerializeField]
			private string screenConfigName;

			public string ScreenConfigName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Settings(TextAnchor childAlignment, bool expandWidth, bool expandHeight, Axis orientation)
			{
			}
		}

		[Serializable]
		public class SettingsConfigCollection : SizeConfigCollection<Settings>
		{
			public SettingsConfigCollection()
			{
				((SizeConfigCollection<>)(object)this)._002Ector();
			}
		}

		public enum Axis
		{
			Horizontal = 0,
			Vertical = 1
		}

		[CompilerGenerated]
		private sealed class _003CSetDirtyDelayed_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BetterAxisAlignedLayoutGroup _003C_003E4__this;

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
			public _003CSetDirtyDelayed_003Ed__23(int _003C_003E1__state)
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
		private sealed class _003CInitDelayed_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BetterAxisAlignedLayoutGroup _003C_003E4__this;

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
			public _003CInitDelayed_003Ed__25(int _003C_003E1__state)
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

		[SerializeField]
		private MarginSizeModifier paddingSizerFallback;

		[SerializeField]
		private MarginSizeConfigCollection customPaddingSizers;

		[SerializeField]
		private FloatSizeModifier spacingSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection customSpacingSizers;

		[SerializeField]
		private Settings settingsFallback;

		[SerializeField]
		private SettingsConfigCollection customSettings;

		[SerializeField]
		private Axis orientation;

		public MarginSizeModifier PaddingSizer => null;

		public FloatSizeModifier SpacingSizer => null;

		public Settings CurrentSettings => null;

		public Axis Orientation
		{
			get
			{
				return default(Axis);
			}
			set
			{
			}
		}

		private bool isVertical => false;

		protected override void OnEnable()
		{
		}

		protected override void OnTransformChildrenChanged()
		{
		}

		[IteratorStateMachine(typeof(_003CSetDirtyDelayed_003Ed__23))]
		private IEnumerator SetDirtyDelayed()
		{
			return null;
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		[IteratorStateMachine(typeof(_003CInitDelayed_003Ed__25))]
		private IEnumerator InitDelayed()
		{
			return null;
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		public void OnResolutionChanged()
		{
		}

		public void CalculateCellSize()
		{
		}

		private void ApplySettings(Settings settings)
		{
		}
	}
}
