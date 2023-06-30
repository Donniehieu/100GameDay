using System;
using UnityEngine;

namespace SRF.UI
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("SRF/UI/Responsive (Enable)")]
	public class ResponsiveResize : ResponsiveBase
	{
		[Serializable]
		public struct Element
		{
			[Serializable]
			public struct SizeDefinition
			{
				[Tooltip("Width to apply when over the threshold width")]
				public float ElementWidth;

				[Tooltip("Threshold over which this width will take effect")]
				public float ThresholdWidth;
			}

			public SizeDefinition[] SizeDefinitions;

			public RectTransform Target;
		}

		public Element[] Elements;

		protected override void Refresh()
		{
		}
	}
}
