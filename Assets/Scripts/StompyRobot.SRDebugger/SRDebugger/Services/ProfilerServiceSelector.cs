using System;
using SRF.Service;

namespace SRDebugger.Services
{
	public static class ProfilerServiceSelector
	{
		[ServiceSelector(typeof(IProfilerService))]
		public static Type GetProfilerServiceType()
		{
			return null;
		}
	}
}
