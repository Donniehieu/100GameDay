using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public class TableColumnWidthAttribute : Attribute
	{
		public int Width;

		public bool Resizable;

		public TableColumnWidthAttribute(int width, bool resizable = true)
		{
		}
	}
}
