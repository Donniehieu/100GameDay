using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	[StructLayout(0, Size = 1)]
	public struct ProfilingScope : IDisposable
	{
		public ProfilingScope(CommandBuffer cmd, ProfilingSampler sampler)
		{
		}

		public void Dispose()
		{
		}
	}
}
