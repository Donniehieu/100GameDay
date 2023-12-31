using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public class SirenixBuildVersionAttribute : Attribute
	{
		public string Version
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

		public SirenixBuildVersionAttribute(string version)
		{
		}
	}
}
