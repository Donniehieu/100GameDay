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
	public struct uint3 : IEquatable<uint3>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
			public uint x;

			public uint y;

			public uint z;

			public DebuggerProxy(uint3 v)
			{
			}
		}

		public uint x;

		public uint y;

		public uint z;

		public static readonly uint3 zero;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zx
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zy
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[MethodImpl(256)]
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zz
		{
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		public uint Item
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[MethodImpl(256)]
		public uint3(uint x, uint y, uint z)
		{
		}

		[MethodImpl(256)]
		public uint3(uint x, uint2 yz)
		{
		}

		[MethodImpl(256)]
		public uint3(uint2 xy, uint z)
		{
		}

		[MethodImpl(256)]
		public uint3(uint3 xyz)
		{
		}

		[MethodImpl(256)]
		public uint3(uint v)
		{
		}

		[MethodImpl(256)]
		public uint3(bool v)
		{
		}

		[MethodImpl(256)]
		public uint3(bool3 v)
		{
		}

		[MethodImpl(256)]
		public uint3(int v)
		{
		}

		[MethodImpl(256)]
		public uint3(int3 v)
		{
		}

		[MethodImpl(256)]
		public uint3(float v)
		{
		}

		[MethodImpl(256)]
		public uint3(float3 v)
		{
		}

		[MethodImpl(256)]
		public uint3(double v)
		{
		}

		[MethodImpl(256)]
		public uint3(double3 v)
		{
		}

		[MethodImpl(256)]
		public static implicit operator uint3(uint v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static explicit operator uint3(bool v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static explicit operator uint3(bool3 v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static explicit operator uint3(int v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static explicit operator uint3(int3 v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static explicit operator uint3(float v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static explicit operator uint3(float3 v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static explicit operator uint3(double v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static explicit operator uint3(double3 v)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator *(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator *(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator *(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator +(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator +(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator +(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator -(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator -(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator -(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator /(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator /(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator /(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator %(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator %(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator %(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator ++(uint3 val)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator --(uint3 val)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static bool3 operator <(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator <(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator <(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator <=(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator <=(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator <=(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator >(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator >(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator >(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator >=(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator >=(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator >=(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static uint3 operator -(uint3 val)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator +(uint3 val)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator <<(uint3 x, int n)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator >>(uint3 x, int n)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static bool3 operator ==(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator ==(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator ==(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator !=(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator !=(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static bool3 operator !=(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		[MethodImpl(256)]
		public static uint3 operator ~(uint3 val)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator &(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator &(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator &(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator |(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator |(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator |(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator ^(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator ^(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public static uint3 operator ^(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		[MethodImpl(256)]
		public bool Equals(uint3 rhs)
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
