namespace Sirenix.Utilities.Unsafe
{
	public static class UnsafeUtilities
	{
		public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength) where T : struct
		{
			return null;
		}

		public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength, int byteOffset) where T : struct
		{
			return null;
		}

		public static byte[] StructArrayToBytes<T>(T[] array) where T : struct
		{
			return null;
		}

		public static byte[] StructArrayToBytes<T>(T[] array, ref byte[] bytes, int byteOffset) where T : struct
		{
			return null;
		}

		public static string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport)
		{
			return null;
		}

		public static int StringToBytes(byte[] buffer, string value, bool needs16BitSupport)
		{
			return 0;
		}

		public static void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset)
		{
		}
	}
}
