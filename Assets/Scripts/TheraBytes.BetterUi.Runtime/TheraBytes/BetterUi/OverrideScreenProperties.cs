using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TheraBytes.BetterUi
{
	[ExecuteAlways]
	[HelpURL("https://documentation.therabytes.de/better-ui/OverrideScreenProperties.html")]
	[AddComponentMenu("Better UI/Layout/Override Screen Properties", 30)]
	public class OverrideScreenProperties : UIBehaviour, IResolutionDependency
	{
		public enum ScreenProperty
		{
			Width = 0,
			Height = 1,
			Dpi = 2
		}

		public enum OverrideMode
		{
			Override = 0,
			Inherit = 1,
			ActualScreenProperty = 2
		}

		[Serializable]
		[DefaultMember("Item")]
		public class Settings : IScreenConfigConnection
		{
			[Serializable]
			public class OverrideProperty
			{
				[SerializeField]
				private OverrideMode mode;

				[SerializeField]
				private float value;

				public OverrideMode Mode => default(OverrideMode);

				public float Value => 0f;
			}

			[CompilerGenerated]
			private sealed class _003CPropertyIterator_003Ed__4 : IEnumerable<OverrideProperty>, IEnumerable, IEnumerator<OverrideProperty>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private OverrideProperty _003C_003E2__current;

				private int _003C_003El__initialThreadId;

				public Settings _003C_003E4__this;

				private OverrideProperty System_002ECollections_002EGeneric_002EIEnumerator_003CTheraBytes_002EBetterUi_002EOverrideScreenProperties_002ESettings_002EOverrideProperty_003E_002ECurrent
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
				public _003CPropertyIterator_003Ed__4(int _003C_003E1__state)
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

				[DebuggerHidden]
				private IEnumerator<OverrideProperty> System_002ECollections_002EGeneric_002EIEnumerable_003CTheraBytes_002EBetterUi_002EOverrideScreenProperties_002ESettings_002EOverrideProperty_003E_002EGetEnumerator()
				{
					return null;
				}

				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			public OverrideProperty OptimizedWidthOverride;

			public OverrideProperty OptimizedHeightOverride;

			public OverrideProperty OptimizedDpiOverride;

			[SerializeField]
			private string screenConfigName;

			public OverrideProperty Item => null;

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

			[IteratorStateMachine(typeof(_003CPropertyIterator_003Ed__4))]
			public IEnumerable<OverrideProperty> PropertyIterator()
			{
				return null;
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
		private sealed class _003CRecalculateRoutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OverrideScreenProperties _003C_003E4__this;

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
			public _003CRecalculateRoutine_003Ed__18(int _003C_003E1__state)
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
		private Settings settingsFallback;

		[SerializeField]
		private SettingsConfigCollection customSettings;

		private ScreenInfo optimizedOverride;

		private ScreenInfo currentOverride;

		public Settings CurrentSettings => null;

		public ScreenInfo OptimizedOverride => null;

		public ScreenInfo CurrentSize => null;

		protected override void OnEnable()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		public void OnResolutionChanged()
		{
		}

		[IteratorStateMachine(typeof(_003CRecalculateRoutine_003Ed__18))]
		private IEnumerator RecalculateRoutine()
		{
			return null;
		}

		private void Recalculate(Settings settings)
		{
		}

		public float CalculateOptimizedValue(Settings settings, ScreenProperty property, OverrideScreenProperties parent)
		{
			return 0f;
		}

		private float CalculateCurrentValue(Settings settings, ScreenProperty property, OverrideScreenProperties parent, Rect rect)
		{
			return 0f;
		}

		public void InformChildren()
		{
		}
	}
}
