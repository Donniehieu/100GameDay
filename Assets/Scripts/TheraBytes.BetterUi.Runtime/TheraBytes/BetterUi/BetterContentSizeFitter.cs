using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterContentSizeFitter.html")]
	[AddComponentMenu("Better UI/Layout/Better Content Size Fitter", 30)]
	[ExecuteAlways]
	public class BetterContentSizeFitter : ContentSizeFitter, IResolutionDependency, ILayoutChildDependency
	{
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			public FitMode HorizontalFit;

			public FitMode VerticalFit;

			public bool IsAnimated;

			public float AnimationTime;

			public bool HasMinWidth;

			public bool HasMinHeight;

			public bool HasMaxWidth;

			public bool HasMaxHeight;

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
		private sealed class _003CCoAnimate_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BetterContentSizeFitter _003C_003E4__this;

			private float _003Ct_003E5__2;

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
			public _003CCoAnimate_003Ed__40(int _003C_003E1__state)
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
		private RectTransform source;

		[SerializeField]
		private Settings settingsFallback;

		[SerializeField]
		private SettingsConfigCollection customSettings;

		[SerializeField]
		private FloatSizeModifier minWidthSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection minWidthSizers;

		[SerializeField]
		private FloatSizeModifier minHeightSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection minHeightSizers;

		[SerializeField]
		private FloatSizeModifier maxWidthSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection maxWidthSizers;

		[SerializeField]
		private FloatSizeModifier maxHeightSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection maxHeightSizers;

		[SerializeField]
		private Vector2SizeModifier paddingFallback;

		[SerializeField]
		private Vector2SizeConfigCollection paddingSizers;

		private RectTransformData start;

		private RectTransformData end;

		private bool isAnimating;

		private RectTransform rectTransform => null;

		public Settings CurrentSettings => null;

		public RectTransform Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnResolutionChanged()
		{
		}

		private void Apply()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		private void SetLayout(int axis)
		{
		}

		private void ApplyOffsetToDefaultSize(int axis, FitMode fitMode)
		{
		}

		private float ClampSize(RectTransform.Axis axis, float size)
		{
			return 0f;
		}

		private Bounds GetChildBounds()
		{
			return default(Bounds);
		}

		public void ChildSizeChanged(Transform child)
		{
		}

		public void ChildAddedOrEnabled(Transform child)
		{
		}

		public void ChildRemovedOrDisabled(Transform child)
		{
		}

		private void ChildChanged()
		{
		}

		private void Animate()
		{
		}

		[IteratorStateMachine(typeof(_003CCoAnimate_003Ed__40))]
		private IEnumerator CoAnimate()
		{
			return null;
		}
	}
}
