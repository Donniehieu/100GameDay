using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	internal sealed class NotNullWhenAttribute : Attribute
	{
		public bool ReturnValue
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public NotNullWhenAttribute(bool returnValue)
		{
		}
	}
}
