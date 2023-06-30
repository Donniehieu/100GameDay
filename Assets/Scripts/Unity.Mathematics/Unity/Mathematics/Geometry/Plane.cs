using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics.Geometry
{
	[Serializable]
	[DebuggerDisplay("{Normal}, {Distance}")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	internal struct Plane
	{
		public float4 NormalAndDistance;

		public float3 Normal
		{
			get
			{
				return default(float3);
			}
			set
			{
			}
		}

		public float Distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Plane Flipped => default(Plane);

		[MethodImpl(256)]
		public Plane(float coefficientA, float coefficientB, float coefficientC, float coefficientD)
		{
		}

		[MethodImpl(256)]
		public Plane(float3 normal, float distance)
		{
		}

		[MethodImpl(256)]
		public Plane(float3 normal, float3 pointInPlane)
		{
		}

		[MethodImpl(256)]
		public Plane(float3 vector1InPlane, float3 vector2InPlane, float3 pointInPlane)
		{
		}

		[MethodImpl(256)]
		public static Plane CreateFromUnitNormalAndDistance(float3 unitNormal, float distance)
		{
			return default(Plane);
		}

		[MethodImpl(256)]
		public static Plane CreateFromUnitNormalAndPointInPlane(float3 unitNormal, float3 pointInPlane)
		{
			return default(Plane);
		}

		[MethodImpl(256)]
		public static Plane Normalize(Plane plane)
		{
			return default(Plane);
		}

		[MethodImpl(256)]
		public static float4 Normalize(float4 planeCoefficients)
		{
			return default(float4);
		}

		[MethodImpl(256)]
		public float SignedDistanceToPoint(float3 point)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public float3 Projection(float3 point)
		{
			return default(float3);
		}

		[MethodImpl(256)]
		public static implicit operator float4(Plane plane)
		{
			return default(float4);
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckPlaneIsNormalized()
		{
		}
	}
}
