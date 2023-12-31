using System;
using System.Runtime.CompilerServices;

namespace SRF.Service
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ServiceSelectorAttribute : Attribute
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

		public ServiceSelectorAttribute(Type serviceType)
		{
		}
	}
}
