using System;
using UnityEngine;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Selectable Renderer Color")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanSelectableRendererColor")]
	[RequireComponent(typeof(Renderer))]
	public class LeanSelectableRendererColor : LeanSelectableBehaviour
	{
		[Tooltip("Automatically read the DefaultColor from the material?")]
		public bool AutoGetDefaultColor;

		[Tooltip("The default color given to the materials.")]
		public Color DefaultColor;

		[Tooltip("The color given to the materials when selected.")]
		public Color SelectedColor;

		[Tooltip("Should the materials get cloned at the start?")]
		public bool CloneMaterials;

		[NonSerialized]
		private Renderer cachedRenderer;

		protected virtual void Awake()
		{
		}

		protected override void OnSelect(LeanFinger finger)
		{
		}

		protected override void OnDeselect()
		{
		}

		private void ChangeColor(Color color)
		{
		}
	}
}
