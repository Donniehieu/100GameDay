using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	[StructLayout(0, Size = 1)]
	[Obsolete("VolumeIsolationScope is deprecated, it does not have any effect anymore.")]
	public struct VolumeIsolationScope : IDisposable
	{
		public VolumeIsolationScope(bool unused)
		{
		}

		private void System_002EIDisposable_002EDispose()
		{
		}
	}
}
