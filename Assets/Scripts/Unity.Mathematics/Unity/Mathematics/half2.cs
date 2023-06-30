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
	public struct half2 : IEquatable<half2>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
			public half x;

			public half y;

			public DebuggerProxy(half2 v)
			{
			}
		}

		public half x;

		public half y;

		public static readonly half2 zero;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxx
		{
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxy
		{
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyx
		{
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyy
		{
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxx
		{
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxy
		{
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyx
		{
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyy
		{
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xx
		{
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xy
		{
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yx
		{
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yy
		{
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		public half Item
		{
			get
			{
				return default(half);
			}
			set
			{
			}
		}

		[MethodImpl(256)]
		public half2(half x, half y)
		{
		}

		[MethodImpl(256)]
		public half2(half2 xy)
		{
		}

		[MethodImpl(256)]
		public half2(half v)
		{
		}

		[MethodImpl(256)]
		public half2(float v)
		{
		}

		[MethodImpl(256)]
		public half2(float2 v)
		{
		}

		[MethodImpl(256)]
		public half2(double v)
		{
		}

		[MethodImpl(256)]
		public half2(double2 v)
		{
		}

		[MethodImpl(256)]
		public static implicit operator half2(half v)
		{
			return default(half2);
		}

		[MethodImpl(256)]
		public static explicit operator half2(float v)
		{
			return default(half2);
		}

		[MethodImpl(256)]
		public static explicit operator half2(float2 v)
		{
			return default(half2);
		}

		[MethodImpl(256)]
		public static explicit operator half2(double v)
		{
			return default(half2);
		}

		[MethodImpl(256)]
		public static explicit operator half2(double2 v)
		{
			return default(half2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(half2 lhs, half2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(half2 lhs, half rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(half lhs, half2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(half2 lhs, half2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(half2 lhs, half rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(half lhs, half2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public bool Equals(half2 rhs)
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
