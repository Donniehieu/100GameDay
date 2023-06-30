using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	public class ButtonAttribute : ShowInInspectorAttribute
	{
		public int ButtonHeight;

		public string Name;

		public ButtonStyle Style;

		public bool Expanded;

		public bool DisplayParameters;

		public bool DirtyOnClick;

		private bool drawResult;

		private bool drawResultIsSet;

		public bool DrawResult
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DrawResultIsSet => false;

		public ButtonAttribute()
		{
		}

		public ButtonAttribute(ButtonSizes size)
		{
		}

		public ButtonAttribute(int buttonSize)
		{
		}

		public ButtonAttribute(string name)
		{
		}

		public ButtonAttribute(string name, ButtonSizes buttonSize)
		{
		}

		public ButtonAttribute(string name, int buttonSize)
		{
		}

		public ButtonAttribute(ButtonStyle parameterBtnStyle)
		{
		}

		public ButtonAttribute(int buttonSize, ButtonStyle parameterBtnStyle)
		{
		}

		public ButtonAttribute(ButtonSizes size, ButtonStyle parameterBtnStyle)
		{
		}

		public ButtonAttribute(string name, ButtonStyle parameterBtnStyle)
		{
		}

		public ButtonAttribute(string name, ButtonSizes buttonSize, ButtonStyle parameterBtnStyle)
		{
		}

		public ButtonAttribute(string name, int buttonSize, ButtonStyle parameterBtnStyle)
		{
		}
	}
}
