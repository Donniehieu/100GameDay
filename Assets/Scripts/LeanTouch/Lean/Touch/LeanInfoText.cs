using UnityEngine;
using UnityEngine.UI;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Info Text")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanInfoText")]
	public class LeanInfoText : MonoBehaviour
	{
		public Text Target;

		[Tooltip("The final text will use this string formatting.")]
		[Multiline]
		public string Format;

		public void Display(string value)
		{
		}

		public void Display(string valueA, string valueB)
		{
		}

		public void Display(int value)
		{
		}

		public void Display(float value)
		{
		}

		public void Display(Vector2 value)
		{
		}

		public void Display(Vector3 value)
		{
		}

		public void Display(Vector4 value)
		{
		}

		public void Display(int valueA, int valueB)
		{
		}
	}
}
