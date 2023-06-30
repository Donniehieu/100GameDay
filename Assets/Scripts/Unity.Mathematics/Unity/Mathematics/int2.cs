using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DefaultMember("Item")]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	public struct int2 : IEquatable<int2>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
			public int x;

			public int y;

			public DebuggerProxy(int2 v)
			{
			}
		}

		public int x;

		public int y;

		public static readonly int2 zero;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxx
		{
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxy
		{
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyx
		{
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyy
		{
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxx
		{
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxy
		{
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyx
		{
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyy
		{
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xx
		{
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy
		{
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yx
		{
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yy
		{
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		public int Item
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[MethodImpl(256)]
		public int2(int x, int y)
		{
		}

		[MethodImpl(256)]
		public int2(int2 xy)
		{
		}

		[MethodImpl(256)]
		public int2(int v)
		{
		}

		[MethodImpl(256)]
		public int2(bool v)
		{
		}

		[MethodImpl(256)]
		public int2(bool2 v)
		{
		}

		[MethodImpl(256)]
		public int2(uint v)
		{
		}

		[MethodImpl(256)]
		public int2(uint2 v)
		{
		}

		[MethodImpl(256)]
		public int2(float v)
		{
		}

		[MethodImpl(256)]
		public int2(float2 v)
		{
		}

		[MethodImpl(256)]
		public int2(double v)
		{
		}

		[MethodImpl(256)]
		public int2(double2 v)
		{
		}

		[MethodImpl(256)]
		public static implicit operator int2(int v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static explicit operator int2(bool v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static explicit operator int2(bool2 v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static explicit operator int2(uint v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static explicit operator int2(uint2 v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static explicit operator int2(float v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static explicit operator int2(float2 v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static explicit operator int2(double v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static explicit operator int2(double2 v)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator *(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator *(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator *(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator +(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator +(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator +(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator -(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator -(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator -(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator /(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator /(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator /(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator %(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator %(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator %(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator ++(int2 val)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator --(int2 val)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static int2 operator -(int2 val)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator +(int2 val)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator <<(int2 x, int n)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator >>(int2 x, int n)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static int2 operator ~(int2 val)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator &(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator &(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator &(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator |(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator |(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator |(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator ^(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator ^(int2 lhs, int rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public static int2 operator ^(int lhs, int2 rhs)
		{
			return default(int2);
		}

		[MethodImpl(256)]
		public bool Equals(int2 rhs)
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
