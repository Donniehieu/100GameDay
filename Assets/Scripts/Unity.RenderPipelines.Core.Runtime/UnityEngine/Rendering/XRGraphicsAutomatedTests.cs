using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public static class XRGraphicsAutomatedTests
	{
		public static bool running;

		private static bool activatedFromCommandLine => false;

		public static bool enabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}
	}
}
