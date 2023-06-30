using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct Random
	{
		public uint state;

		[MethodImpl(256)]
		public Random(uint seed)
		{
		}

		[MethodImpl(256)]
		public static Random CreateFromIndex(uint index)
		{
			return default(Random);
		}

		[MethodImpl(256)]
		internal static uint WangHash(uint n)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public void InitState(uint seed = 1851936439u)
		{
		}

		[MethodImpl(256)]
		public bool NextBool()
		{
			return false;
		}

		[MethodImpl(256)]
		public bool2 NextBool2()
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public bool3 NextBool3()
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public bool4 NextBool4()
		{
			return default(bool4);
		}

		[MethodImpl(256)]
		public int NextInt()
		{
			return 0;
		}

		[MethodImpl(256)]
		public int2 NextInt2()
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public int3 NextInt3()
		{
			return default(int3);
		}

		[MethodImpl(256)]
		public int4 NextInt4()
		{
			return default(int4);
		}

		[MethodImpl(256)]
		public int NextInt(int max)
		{
			return 0;
		}

		[MethodImpl(256)]
		public int2 NextInt2(int2 max)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public int3 NextInt3(int3 max)
		{
			return default(int3);
		}

		[MethodImpl(256)]
		public int4 NextInt4(int4 max)
		{
			return default(int4);
		}

		[MethodImpl(256)]
		public int NextInt(int min, int max)
		{
			return 0;
		}

		[MethodImpl(256)]
		public int2 NextInt2(int2 min, int2 max)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public int3 NextInt3(int3 min, int3 max)
		{
			return default(int3);
		}

		[MethodImpl(256)]
		public int4 NextInt4(int4 min, int4 max)
		{
			return default(int4);
		}

		[MethodImpl(256)]
		public uint NextUInt()
		{
			return 0u;
		}

		[MethodImpl(256)]
		public uint2 NextUInt2()
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		public uint3 NextUInt3()
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public uint4 NextUInt4()
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		public uint NextUInt(uint max)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public uint2 NextUInt2(uint2 max)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		public uint3 NextUInt3(uint3 max)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public uint4 NextUInt4(uint4 max)
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		public uint NextUInt(uint min, uint max)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public uint2 NextUInt2(uint2 min, uint2 max)
		{
			return default(uint2);
		}

		[MethodImpl(256)]
		public uint3 NextUInt3(uint3 min, uint3 max)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public uint4 NextUInt4(uint4 min, uint4 max)
		{
			return default(uint4);
		}

		[MethodImpl(256)]
		public float NextFloat()
		{
			return 0f;
		}

		[MethodImpl(256)]
		public float2 NextFloat2()
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public float3 NextFloat3()
		{
			return default(float3);
		}

		[MethodImpl(256)]
		public float4 NextFloat4()
		{
			return default(float4);
		}

		[MethodImpl(256)]
		public float NextFloat(float max)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public float2 NextFloat2(float2 max)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public float3 NextFloat3(float3 max)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		public float4 NextFloat4(float4 max)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		public float NextFloat(float min, float max)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public float2 NextFloat2(float2 min, float2 max)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public float3 NextFloat3(float3 min, float3 max)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		public float4 NextFloat4(float4 min, float4 max)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		public double NextDouble()
		{
			return 0.0;
		}

		[MethodImpl(256)]
		public double2 NextDouble2()
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public double3 NextDouble3()
		{
			return default(double3);
		}

		[MethodImpl(256)]
		public double4 NextDouble4()
		{
			return default(double4);
		}

		[MethodImpl(256)]
		public double NextDouble(double max)
		{
			return 0.0;
		}

		[MethodImpl(256)]
		public double2 NextDouble2(double2 max)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public double3 NextDouble3(double3 max)
		{
			return default(double3);
		}

		[MethodImpl(256)]
		public double4 NextDouble4(double4 max)
		{
			return default(double4);
		}

		[MethodImpl(256)]
		public double NextDouble(double min, double max)
		{
			return 0.0;
		}

		[MethodImpl(256)]
		public double2 NextDouble2(double2 min, double2 max)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public double3 NextDouble3(double3 min, double3 max)
		{
			return default(double3);
		}

		[MethodImpl(256)]
		public double4 NextDouble4(double4 min, double4 max)
		{
			return default(double4);
		}

		[MethodImpl(256)]
		public float2 NextFloat2Direction()
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public double2 NextDouble2Direction()
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public float3 NextFloat3Direction()
		{
			return default(float3);
		}

		[MethodImpl(256)]
		public double3 NextDouble3Direction()
		{
			return default(double3);
		}

		[MethodImpl(256)]
		public quaternion NextQuaternionRotation()
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		private uint NextState()
		{
			return 0u;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckInitState()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private static void CheckIndexForHash(uint index)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckState()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckNextIntMax(int max)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckNextIntMinMax(int min, int max)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckNextUIntMinMax(uint min, uint max)
		{
		}
	}
}
