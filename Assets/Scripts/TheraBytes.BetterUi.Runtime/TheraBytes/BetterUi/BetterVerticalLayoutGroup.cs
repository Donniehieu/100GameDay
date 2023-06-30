using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[Obsolete("Better use BetterAxisAlignedLayoutGroup.")]
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterVerticalLayoutGroup.html")]
	[AddComponentMenu("Better UI/Obsolete/Better Vertical Layout Group", 30)]
	public class BetterVerticalLayoutGroup : VerticalLayoutGroup, IBetterHorizontalOrVerticalLayoutGroup, IResolutionDependency
	{
		[FormerlySerializedAs("paddingSizer")]
		[SerializeField]
		private MarginSizeModifier paddingSizerFallback;

		[FormerlySerializedAs("spacingSizer")]
		[SerializeField]
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
