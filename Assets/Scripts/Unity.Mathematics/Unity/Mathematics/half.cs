using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct half : IEquatable<half>, IFormattable
	{
		public ushort value;

		public static readonly half zero;

		public static float MaxValue => 0f;

		public static float MinValue => 0f;

		public static half MaxValueAsHalf => default(half);

		public static half MinValueAsHalf => default(half);

		[MethodImpl(256)]
		public half(half x)
		{
		}

		[MethodImpl(256)]
		public half(float v)
		{
		}

		[MethodImpl(256)]
		public half(double v)
		{
		}

		[MethodImpl(256)]
		public static explicit operator half(float v)
		{
			return default(half);
		}

		[MethodImpl(256)]
		public static explicit operator half(double v)
		{
			return default(half);
		}

		[MethodImpl(256)]
		public static implicit operator float(half d)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public static implicit operator double(half d)
		{
			return 0.0;
		}

		[MethodImpl(256)]
		public static bool operator ==(half lhs, half rhs)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool operator !=(half lhs, half rhs)
		{
			return false;
		}

		[MethodImpl(256)]
		public bool Equals(half rhs)
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
