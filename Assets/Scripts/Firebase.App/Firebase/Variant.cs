using System;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class Variant : IDisposable
	{
		public enum Type
		{
			Null = 0,
			Int64 = 1,
			Double = 2,
			Bool = 3,
			StaticString = 4,
			MutableString = 5,
			Vector = 6,
			Map = 7,
			StaticBlob = 8,
			MutableBlob = 9
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal Variant(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(Variant obj)
		{
			return default(HandleRef);
		}

		~Variant()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public static Variant FromBlob(byte[] blob)
		{
			return null;
		}

		public byte[] blob_as_bytes()
		{
			return null;
		}

		public static Variant FromObject(object o)
		{
			return null;
		}

		public static Variant Null()
		{
			return null;
		}

		public static Variant EmptyVector()
		{
			return null;
		}

		public static Variant EmptyMap()
		{
			return null;
		}

		public static Variant EmptyMutableBlob(uint sizeBytes)
		{
			return null;
		}

		public Type type()
		{
			return default(Type);
		}

		public bool is_string()
		{
			return false;
		}

		public bool is_fundamental_type()
		{
			return false;
		}

		public Variant AsString()
		{
			return null;
		}

		public uint blob_size()
		{
			return 0u;
		}

		public VariantList vector()
		{
			return null;
		}

		public VariantVariantMap map()
		{
			return null;
		}

		public long int64_value()
		{
			return 0L;
		}

		public double double_value()
		{
			return 0.0;
		}

		public bool bool_value()
		{
			return false;
		}

		public string string_value()
		{
			return null;
		}

		public static Variant FromInt64(long value)
		{
			return null;
		}

		public static Variant FromDouble(double value)
		{
			return null;
		}

		public static Variant FromBool(bool value)
		{
			return null;
		}

		public static Variant FromString(string value)
		{
			return null;
		}

		public IntPtr untyped_mutable_blob_data()
		{
			return (IntPtr)0;
		}
	}
}
