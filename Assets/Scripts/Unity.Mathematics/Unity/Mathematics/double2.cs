using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[DefaultMember("Item")]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct double2 : IEquatable<double2>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
			public double x;

			public double y;

			public DebuggerProxy(double2 v)
			{
			}
		}

		public double x;

		public double y;

		public static readonly double2 zero;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxx
		{
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxy
		{
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyx
		{
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyy
		{
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxx
		{
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxy
		{
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyx
		{
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyy
		{
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xx
		{
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xy
		{
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yx
		{
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yy
		{
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		public double Item
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[MethodImpl(256)]
		public double2(double x, double y)
		{
		}

		[MethodImpl(256)]
		public double2(double2 xy)
		{
		}

		[MethodImpl(256)]
		public double2(double v)
		{
		}

		[MethodImpl(256)]
		public double2(bool v)
		{
		}

		[MethodImpl(256)]
		public double2(bool2 v)
		{
		}

		[MethodImpl(256)]
		public double2(int v)
		{
		}

		[MethodImpl(256)]
		public double2(int2 v)
		{
		}

		[MethodImpl(256)]
		public double2(uint v)
		{
		}

		[MethodImpl(256)]
		public double2(uint2 v)
		{
		}

		[MethodImpl(256)]
		public double2(half v)
		{
		}

		[MethodImpl(256)]
		public double2(half2 v)
		{
		}

		[MethodImpl(256)]
		public double2(float v)
		{
		}

		[MethodImpl(256)]
		public double2(float2 v)
		{
		}

		[MethodImpl(256)]
		public static implicit operator double2(double v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static explicit operator double2(bool v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static explicit operator double2(bool2 v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static implicit operator double2(int v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static implicit operator double2(int2 v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static implicit operator double2(uint v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static implicit operator double2(uint2 v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static implicit operator double2(half v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static implicit operator double2(half2 v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static implicit operator double2(float v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static implicit operator double2(float2 v)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator *(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator *(double2 lhs, double rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator *(double lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator +(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator +(double2 lhs, double rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator +(double lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator -(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator -(double2 lhs, double rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator -(double lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator /(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator /(double2 lhs, double rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator /(double lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator %(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator %(double2 lhs, double rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator %(double lhs, double2 rhs)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator ++(double2 val)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator --(double2 val)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static double2 operator -(double2 val)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static double2 operator +(double2 val)
		{
			return default(double2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public bool Equals(double2 rhs)
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
