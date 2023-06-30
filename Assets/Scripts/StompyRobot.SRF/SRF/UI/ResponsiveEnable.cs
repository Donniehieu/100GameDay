using System;
using UnityEngine;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Responsive (Enable)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ResponsiveEnable : ResponsiveBase
	{
		public enum Modes
		{
			EnableAbove = 0,
			EnableBelow = 1
		}

		[Serializable]
		public struct Entry
		{
			public Behaviour[] Components;

			public GameObject[] GameObjects;

			public Modes Mode;

			public float ThresholdHeight;

			public float ThresholdWidth;
		}

		public Entry[] Entries;

		protected override void Refresh()
		{
		}
	}
}
