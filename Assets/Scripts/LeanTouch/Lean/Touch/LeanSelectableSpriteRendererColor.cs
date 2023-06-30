using UnityEngine;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Selectable SpriteRenderer Color")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanSelectableSpriteRendererColor")]
	[RequireComponent(typeof(SpriteRenderer))]
	public class LeanSelectableSpriteRendererColor : LeanSelectableBehaviour
	{
		[Tooltip("Automatically read the DefaultColor from the SpriteRenderer?")]
		public bool AutoGetDefaultColor;

		[Tooltip("The default color given to the SpriteRenderer.")]
		public Color DefaultColor;

		[Tooltip("The color given to the SpriteRenderer when selected.")]
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
