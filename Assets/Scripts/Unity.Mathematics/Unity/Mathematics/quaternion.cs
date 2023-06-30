using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct quaternion : IEquatable<quaternion>, IFormattable
	{
		public float4 value;

		public static readonly quaternion identity;

		public static implicit operator Quaternion(quaternion q)
		{
			return default(Quaternion);
		}

		public static implicit operator quaternion(Quaternion q)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public quaternion(float x, float y, float z, float w)
		{
		}

		[MethodImpl(256)]
		public quaternion(float4 value)
		{
		}

		[MethodImpl(256)]
		public static implicit operator quaternion(float4 v)
		{
			return default(quaternion);
		}

		public quaternion(float3x3 m)
		{
		}

		public quaternion(float4x4 m)
		{
		}

		[MethodImpl(256)]
		public static quaternion AxisAngle(float3 axis, float angle)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerXYZ(float3 xyz)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerXZY(float3 xyz)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerYXZ(float3 xyz)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerYZX(float3 xyz)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerZXY(float3 xyz)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerZYX(float3 xyz)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerXYZ(float x, float y, float z)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerXZY(float x, float y, float z)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerYXZ(float x, float y, float z)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerYZX(float x, float y, float z)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerZXY(float x, float y, float z)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion EulerZYX(float x, float y, float z)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion RotateX(float angle)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion RotateY(float angle)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion RotateZ(float angle)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public static quaternion LookRotation(float3 forward, float3 up)
		{
			return default(quaternion);
		}

		public static quaternion LookRotationSafe(float3 forward, float3 up)
		{
			return default(quaternion);
		}

		[MethodImpl(256)]
		public bool Equals(quaternion x)
		{
			return false;
		}

		[MethodImpl(256)]
		public override bool Equals(object x)
		{
			return false;
		}

		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
