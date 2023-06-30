using System;
using System.Runtime.CompilerServices;

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceConstructorAttribute : Attribute
	{
		public Type ServiceType
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

		public ServiceConstructorAttribute(Type serviceType)
		{
		}
	}
}
