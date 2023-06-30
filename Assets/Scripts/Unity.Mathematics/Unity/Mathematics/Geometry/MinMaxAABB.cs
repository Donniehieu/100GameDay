using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics.Geometry
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	internal struct MinMaxAABB : IEquatable<MinMaxAABB>
	{
		public float3 Min;

		public float3 Max;

		public float3 Extents => default(float3);

		public float3 HalfExtents => default(float3);

		public float3 Center => default(float3);

		public bool IsValid => false;

		public float SurfaceArea => 0f;

		[MethodImpl(256)]
		public MinMaxAABB(float3 min, float3 max)
		{
		}

		[MethodImpl(256)]
		public static MinMaxAABB CreateFromCenterAndExtents(float3 center, float3 extents)
		{
			return default(MinMaxAABB);
		}

		[MethodImpl(256)]
		public static MinMaxAABB CreateFromCenterAndHalfExtents(float3 center, float3 halfExtents)
		{
			return default(MinMaxAABB);
		}

		[MethodImpl(256)]
		public bool Contains(float3 point)
		{
			return false;
		}

		[MethodImpl(256)]
		public bool Contains(MinMaxAABB aabb)
		{
			return false;
		}

		[MethodImpl(256)]
		public bool Overlaps(MinMaxAABB aabb)
		{
			return false;
		}

		[MethodImpl(256)]
		public void Expand(float signedDistance)
		{
		}

		[MethodImpl(256)]
		public void Encapsulate(MinMaxAABB aabb)
		{
		}

		[MethodImpl(256)]
		public void Encapsulate(float3 point)
		{
		}

		[MethodImpl(256)]
		public bool Equals(MinMaxAABB other)
		{
			return false;
		}

		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}
	}
}
