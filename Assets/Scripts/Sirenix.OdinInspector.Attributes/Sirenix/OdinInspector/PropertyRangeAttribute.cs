using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class PropertyRangeAttribute : Attribute
	{
		public double Min;

		public double Max;

		public string MinGetter;

		public string MaxGetter;

		[Obsolete("Use the MinGetter member instead.", false)]
		public string MinMember
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Use the MaxGetter member instead.", false)]
		public string MaxMember
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PropertyRangeAttribute(double min, double max)
		{
		}

		public PropertyRangeAttribute(string minGetter, double max)
		{
		}

		public PropertyRangeAttribute(double min, string maxGetter)
		{
		}

		public PropertyRangeAttribute(string minGetter, string maxGetter)
		{
		}
	}
}
