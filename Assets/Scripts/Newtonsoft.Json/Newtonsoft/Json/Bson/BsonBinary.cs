using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal class BsonBinary : BsonValue
	{
		public BsonBinaryType BinaryType
		{
			[CompilerGenerated]
			get
			{
				return default(BsonBinaryType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BsonBinary(byte[] value, BsonBinaryType binaryType)
			: base(null, default(BsonType))
		{
		}
	}
}
