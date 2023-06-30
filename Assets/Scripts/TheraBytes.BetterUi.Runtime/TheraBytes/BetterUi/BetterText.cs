using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[ExecuteAlways]
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterText.html")]
	[AddComponentMenu("Better UI/Controls/Better Text", 30)]
	public class BetterText : Text, IResolutionDependency
	{
		public enum FittingMode
		{
			SizerOnly = 0,
			StayInBounds = 1,
			BestFit = 2
		}

		[SerializeField]
		private FittingMode fitting;

		[FormerlySerializedAs("fontSizer")]
		[SerializeField]
		private FloatSizeModifier fontSizerFallback;

		[SerializeField]
		private FloatSizeConfigCollection customFontSizers;

		private bool isCalculatingSize;

		public FloatSizeModifier FontSizer => null;

		public FittingMode Fitting
		{
			get
			{
				return default(FittingMode);
			}
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

		public override void SetVerticesDirty()
		{
		}

		private void CalculateSize()
		{
		}
	}
}
