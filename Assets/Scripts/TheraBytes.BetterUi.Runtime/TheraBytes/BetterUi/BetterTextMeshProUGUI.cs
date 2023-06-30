using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheraBytes.BetterUi
{
	[AddComponentMenu("Better UI/TextMeshPro/Better TextMeshPro Text", 30)]
	[ExecuteAlways]
	public class BetterTextMeshProUGUI : TextMeshProUGUI, IResolutionDependency
	{
		[SerializeField]
		private BetterText.FittingMode fitting;

		[FormerlySerializedAs("marginSizer")]
		[SerializeField]
		private MarginSizeModifier marginSizerFallback;

		[SerializeField]
		private MarginSizeConfigCollection customMarginSizers;

		[FormerlySerializedAs("fontSizer")]
		[SerializeField]
		private FloatSizeModifier fontSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection customFontSizers;

		[FormerlySerializedAs("minFontSizer")]
		[SerializeField]
		private FloatSizeModifier minFontSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection customMinFontSizers;

		[SerializeField]
		[FormerlySerializedAs("maxFontSizer")]
		private FloatSizeModifier maxFontSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection customMaxFontSizers;

		public BetterText.FittingMode Fitting
		{
			get
			{
				return default(BetterText.FittingMode);
			}
			set
			{
			}
		}

		public MarginSizeModifier MarginSizer => null;

		public FloatSizeModifier FontSizer => null;

		public FloatSizeModifier MinFontSizer => null;

		public FloatSizeModifier MaxFontSizer => null;

		public bool IgnoreFontSizerOptions
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

		protected override void OnEnable()
		{
		}

		public void OnResolutionChanged()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		public void CalculateSize()
		{
		}

		public void RegisterMaterials(Material[] materials)
		{
		}
	}
}
