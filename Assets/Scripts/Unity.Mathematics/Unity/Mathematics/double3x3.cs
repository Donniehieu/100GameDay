using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[DefaultMember("Item")]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct double3x3 : IEquatable<double3x3>, IFormattable
	{
		public double3 c0;

		public double3 c1;

		public double3 c2;

		public static readonly double3x3 identity;

		public static readonly double3x3 zero;

		public unsafe ref double3 Item => ref *(double3*)null;

		[MethodImpl(256)]
		public double3x3(double3 c0, double3 c1, double3 c2)
		{
		}

		[MethodImpl(256)]
		public double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
		{
		}

		[MethodImpl(256)]
		public double3x3(double v)
		{
		}

		[MethodImpl(256)]
		public double3x3(bool v)
		{
		}

		[MethodImpl(256)]
		public double3x3(bool3x3 v)
		{
		}

		[MethodImpl(256)]
		public double3x3(int v)
		{
		}

		[MethodImpl(256)]
		public double3x3(int3x3 v)
		{
		}

		[MethodImpl(256)]
		public double3x3(uint v)
		{
		}

		[MethodImpl(256)]
		public double3x3(uint3x3 v)
		{
		}

		[MethodImpl(256)]
		public double3x3(float v)
		{
		}

		[MethodImpl(256)]
		public double3x3(float3x3 v)
		{
		}

		[MethodImpl(256)]
		public static implicit operator double3x3(double v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static explicit operator double3x3(bool v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static explicit operator double3x3(bool3x3 v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static implicit operator double3x3(int v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static implicit operator double3x3(int3x3 v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static implicit operator double3x3(uint v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static implicit operator double3x3(uint3x3 v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static implicit operator double3x3(float v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static implicit operator double3x3(float3x3 v)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator *(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator *(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator *(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator +(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator +(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator +(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator -(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator -(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator -(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator /(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator /(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator /(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator %(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator %(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator %(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator ++(double3x3 val)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator --(double3x3 val)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator <(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator <(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator <(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator <=(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator <=(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator <=(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator >(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator >(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator >(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator >=(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator >=(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator >=(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator -(double3x3 val)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static double3x3 operator +(double3x3 val)
		{
			return default(double3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator ==(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator ==(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator ==(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator !=(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator !=(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public static bool3x3 operator !=(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		[MethodImpl(256)]
		public bool Equals(double3x3 rhs)
		{
			return false;
		}

		public override bool Equals(object o)
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
