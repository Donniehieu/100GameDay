using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal class BsonString : BsonValue
	{
		public int ByteCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IncludeLength
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public BsonString(object value, bool includeLength)
			: base(null, default(BsonType))
		{
		}
	}
}
