using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal class BsonEmpty : BsonToken
	{
		public static readonly BsonToken Null;

		public static readonly BsonToken Undefined;

		public override BsonType Type
		{
			[CompilerGenerated]
			get
			{
				return default(BsonType);
			}
		}

		private BsonEmpty(BsonType type)
		{
		}
	}
}
