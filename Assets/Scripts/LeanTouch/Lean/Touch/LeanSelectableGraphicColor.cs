using UnityEngine;
using UnityEngine.UI;

namespace Lean.Touch
{
	[RequireComponent(typeof(Graphic))]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanSelectableGraphicColor")]
	[AddComponentMenu("Lean/Touch/Lean Selectable Graphic Color")]
	public class LeanSelectableGraphicColor : LeanSelectableBehaviour
	{
		[Tooltip("Automatically read the DefaultColor from the Renderer.material?")]
		public bool AutoGetDefaultColor;

		[Tooltip("The default color given to the Renderer.material.")]
		public Color DefaultColor;

		[Tooltip("The color given to the Renderer.material when selected.")]
		public Color SelectedColor;

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
