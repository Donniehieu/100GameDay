using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	internal class DoesNotReturnIfAttribute : Attribute
	{
		public bool ParameterValue
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public DoesNotReturnIfAttribute(bool parameterValue)
		{
		}
	}
}
