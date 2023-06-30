using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal struct DeferredTiler
	{
		internal struct PrePunctualLight
		{
			public float3 posVS;

			public float radius;

			public float minDist;

			public float2 screenPos;

			public ushort visLightIndex;
		}

		private enum ClipResult
		{
			Unknown = 0,
			In = 1,
			Out = 2
		}

		private int m_TilePixelWidth;

		private int m_TilePixelHeight;

		private int m_TileXCount;

		private int m_TileYCount;

		private int m_TileHeaderSize;

		private int m_AvgLightPerTile;

		private int m_TilerLevel;

		private FrustumPlanes m_FrustumPlanes;

		private bool m_IsOrthographic;

		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> m_Counters;

		[NativeDisableContainerSafetyRestriction]
		private NativeArray<ushort> m_TileData;

		[NativeDisableContainerSafetyRestriction]
		private NativeArray<uint> m_TileHeaders;

		[NativeDisableContainerSafetyRestriction]
		private NativeArray<PreTile> m_PreTiles;

		public int TilerLevel => 0;

		public int TileXCount => 0;

		public int TileYCount => 0;

		public int TilePixelWidth => 0;

		public int TilePixelHeight => 0;

		public int TileHeaderSize => 0;

		public int MaxLightPerTile => 0;

		public int TileDataCapacity => 0;

		public NativeArray<ushort> Tiles => default(NativeArray<ushort>);

		public NativeArray<uint> TileHeaders => default(NativeArray<uint>);

		public DeferredTiler(int tilePixelWidth, int tilePixelHeight, int avgLightPerTile, int tilerLevel)
		{
		}

		[MethodImpl(256)]
		public void GetTileOffsetAndCount(int i, int j, out int offset, out int count)
		{
			offset = default(int);
			count = default(int);
		}

		[MethodImpl(256)]
		public int GetTileHeaderOffset(int i, int j)
		{
			return 0;
		}

		public void Setup(int tileDataCapacity)
		{
		}

		public void OnCameraCleanup()
		{
		}

		public void PrecomputeTiles(Matrix4x4 proj, bool isOrthographic, int renderWidth, int renderHeight)
		{
		}

		public void CullFinalLights(ref NativeArray<PrePunctualLight> punctualLights, ref NativeArray<ushort> lightIndices, int lightStartIndex, int lightCount, int istart, int iend, int jstart, int jend)
		{
		}

		public void CullIntermediateLights(ref NativeArray<PrePunctualLight> punctualLights, ref NativeArray<ushort> lightIndices, int lightStartIndex, int lightCount, int istart, int iend, int jstart, int jend)
		{
		}

		[MethodImpl(256)]
		private unsafe int AddTileData(ushort* lightData, ref int size)
		{
			return 0;
		}

		[MethodImpl(256)]
		private static bool IntersectionLineSphere(float3 centre, float radius, float3 raySource, float3 rayDirection, out float t0, out float t1)
		{
			t0 = default(float);
			t1 = default(float);
			return false;
		}

		[MethodImpl(256)]
		private static bool Clip(ref PreTile tile, float3 posVS, float radius)
		{
			return false;
		}

		[MethodImpl(256)]
		private static ClipResult ClipPartial(float4 plane, float4 sidePlaneA, float4 sidePlaneB, float3 posVS, float radius, float radiusSq, ref int insideCount)
		{
			return default(ClipResult);
		}

		[MethodImpl(256)]
		private static float4 MakePlane(float3 pb, float3 pc)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		private static float4 MakePlane(float3 pa, float3 pb, float3 pc)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		private static float DistanceToPlane(float4 plane, float3 p)
		{
			return 0f;
		}

		[MethodImpl(256)]
		private static float SignedSq(float f)
		{
			return 0f;
		}

		[MethodImpl(256)]
		private static float min2(float a, float b)
		{
			return 0f;
		}

		[MethodImpl(256)]
		private static float max2(float a, float b)
		{
			return 0f;
		}

		[MethodImpl(256)]
		private static float max3(float a, float b, float c)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public static uint _f32tof16(float x)
		{
			return 0u;
		}

		[MethodImpl(256)]
		private static int Align(int s, int alignment)
		{
			return 0;
		}
	}
}
