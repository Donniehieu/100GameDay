namespace BigBear.Core.Runtime.Utils
{
	public static class EncryptionUtils
	{
		private static byte[] auxVector;

		private static string auxString;

		public static byte[] EncryptString(string toEncrypt, byte[] aesKey, byte[] aesIV)
		{
			return null;
		}

		public static string DecryptBytes(byte[] toDecrypt, byte[] aesKey, byte[] aesIV)
		{
			return null;
		}

		public static void GenerateAesKeyAndIV(out byte[] aesKey, out byte[] aesIV)
		{
			aesKey = null;
			aesIV = null;
		}
	}
}
