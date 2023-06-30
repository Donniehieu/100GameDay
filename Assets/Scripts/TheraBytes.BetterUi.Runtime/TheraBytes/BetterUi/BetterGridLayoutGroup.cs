using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[ExecuteAlways]
	[AddComponentMenu("Better UI/Layout/Better Grid Layout Group", 30)]
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterGridLayoutGroup.html")]
	public class BetterGridLayoutGroup : GridLayoutGroup, IResolutionDependency
	{
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			public Constraint Constraint;

			public int ConstraintCount;

			public TextAnchor ChildAlignment;

			public Axis StartAxis;

			public Corner StartCorner;

			public bool Fit;

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

			public Settings(BetterGridLayoutGroup grid)
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

		[CompilerGenerated]
		private sealed class _003CInitDelayed_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BetterGridLayoutGroup _003C_003E4__this;

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
			public _003CInitDelayed_003Ed__24(int _003C_003E1__state)
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
		[FormerlySerializedAs("paddingSizer")]
		private MarginSizeModifier paddingSizerFallback;

		[SerializeField]
		private MarginSizeConfigCollection customPaddingSizers;

		[SerializeField]
		[FormerlySerializedAs("cellSizer")]
		private Vector2SizeModifier cellSizerFallback;

		[SerializeField]
		private Vector2SizeConfigCollection customCellSizers;

		[SerializeField]
		[FormerlySerializedAs("spacingSizer")]
		private Vector2SizeModifier spacingSizerFallback;

		[SerializeField]
		private Vector2SizeConfigCollection customSpacingSizers;

		[SerializeField]
		private Settings settingsFallback;

		[SerializeField]
		private SettingsConfigCollection customSettings;

		[SerializeField]
		private bool fit;

		public MarginSizeModifier PaddingSizer => null;

		public Vector2SizeModifier CellSizer => null;

		public Vector2SizeModifier SpacingSizer => null;

		public Settings CurrentSettings => null;

		public bool Fit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		protected override void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CInitDelayed_003Ed__24))]
		private IEnumerator InitDelayed()
		{
			return null;
		}

		public void OnResolutionChanged()
		{
		}

		public void CalculateCellSize()
		{
		}

		public float GetCellWidth()
		{
			return 0f;
		}

		public float GetCellHeight()
		{
			return 0f;
		}

		private void ApplySettings(Settings settings)
		{
		}
	}
}
