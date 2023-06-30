using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public class SirenixBuildNameAttribute : Attribute
	{
		public string BuildName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SirenixBuildNameAttribute(string buildName)
		{
		}
	}
}
