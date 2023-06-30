using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterHorizontalLayoutGroup.html")]
	[Obsolete("Beter use BetterAxisAlignedLayoutGroup.")]
	[AddComponentMenu("Better UI/Obsolete/Better Horizontal Layout Group", 30)]
	public class BetterHorizontalLayoutGroup : HorizontalLayoutGroup, IBetterHorizontalOrVerticalLayoutGroup, IResolutionDependency
	{
		[SerializeField]
		[FormerlySerializedAs("paddingSizer")]
		private MarginSizeModifier paddingSizerFallback;

		[SerializeField]
		[FormerlySerializedAs("spacingSizer")]
		private FloatSizeModifier spacingSizerFallback;

		public MarginSizeModifier PaddingSizer => null;

		public FloatSizeModifier SpacingSizer => null;

		protected override void OnEnable()
		{
		}

		public void OnResolutionChanged()
		{
		}

		public void CalculateCellSize()
		{
		}
	}
}
