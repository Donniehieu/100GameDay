using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal static class DeferredConfig
	{
		public const int kPreferredCBufferSize = 65536;

		public const int kPreferredStructuredBufferSize = 131072;

		public const int kTilePixelWidth = 16;

		public const int kTilePixelHeight = 16;

		public const int kTilerDepth = 3;

		public const int kTilerSubdivisions = 4;

		public const int kAvgLightPerTile = 32;

		public const int kTileDepthInfoIntermediateLevel = -1;

		public const bool kHasNativeQuadSupport = false;

		internal static bool IsOpenGL
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool IsDX10
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool UseCBufferForDepthRange => false;

		internal static bool UseCBufferForTileList => false;

		internal static bool UseCBufferForLightData => false;

		internal static bool UseCBufferForLightList => false;
	}
}
