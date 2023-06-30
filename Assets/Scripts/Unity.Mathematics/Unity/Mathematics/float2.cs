using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	[DefaultMember("Item")]
	public struct float2 : IEquatable<float2>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
			public float x;

			public float y;

			public DebuggerProxy(float2 v)
			{
			}
		}

		public float x;

		public float y;

		public static readonly float2 zero;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx
		{
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxy
		{
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyx
		{
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyy
		{
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxx
		{
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxy
		{
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyx
		{
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyy
		{
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx
		{
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy
		{
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx
		{
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy
		{
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		public float Item
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[MethodImpl(256)]
		public float2(float x, float y)
		{
		}

		[MethodImpl(256)]
		public float2(float2 xy)
		{
		}

		[MethodImpl(256)]
		public float2(float v)
		{
		}

		[MethodImpl(256)]
		public float2(bool v)
		{
		}

		[MethodImpl(256)]
		public float2(bool2 v)
		{
		}

		[MethodImpl(256)]
		public float2(int v)
		{
		}

		[MethodImpl(256)]
		public float2(int2 v)
		{
		}

		[MethodImpl(256)]
		public float2(uint v)
		{
		}

		[MethodImpl(256)]
		public float2(uint2 v)
		{
		}

		[MethodImpl(256)]
		public float2(half v)
		{
		}

		[MethodImpl(256)]
		public float2(half2 v)
		{
		}

		[MethodImpl(256)]
		public float2(double v)
		{
		}

		[MethodImpl(256)]
		public float2(double2 v)
		{
		}

		[MethodImpl(256)]
		public static implicit operator float2(float v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static explicit operator float2(bool v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static explicit operator float2(bool2 v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static implicit operator float2(int v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static implicit operator float2(int2 v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static implicit operator float2(uint v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static implicit operator float2(uint2 v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static implicit operator float2(half v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static implicit operator float2(half2 v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static explicit operator float2(double v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static explicit operator float2(double2 v)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator *(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator *(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator *(float lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator +(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator +(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator +(float lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator -(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator -(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator -(float lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator /(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator /(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator /(float lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator %(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator %(float2 lhs, float rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator %(float lhs, float2 rhs)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator ++(float2 val)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator --(float2 val)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator <=(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator >=(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static float2 operator -(float2 val)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static float2 operator +(float2 val)
		{
			return default(float2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator ==(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public static bool2 operator !=(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		[MethodImpl(256)]
		public bool Equals(float2 rhs)
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

		public static implicit operator Vector2(float2 v)
		{
			return default(Vector2);
		}

		public static implicit operator float2(Vector2 v)
		{
			return default(float2);
		}
	}
}
