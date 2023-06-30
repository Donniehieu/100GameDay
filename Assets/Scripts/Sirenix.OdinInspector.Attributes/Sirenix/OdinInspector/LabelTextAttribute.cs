using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	public class LabelTextAttribute : Attribute
	{
		public string Text;

		public bool NicifyText;

		public LabelTextAttribute(string text)
		{
		}

		public LabelTextAttribute(string text, bool nicifyText)
		{
		}
	}
}
