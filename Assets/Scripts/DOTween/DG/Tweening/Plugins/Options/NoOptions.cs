using System.Runtime.InteropServices;

namespace DG.Tweening.Plugins.Options
{
	[StructLayout(0, Size = 1)]
	public struct NoOptions : IPlugOptions
	{
		public void Reset()
		{
		}
	}
}
