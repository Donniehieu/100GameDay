using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal class BsonRegex : BsonToken
	{
		public BsonString Pattern
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BsonString Options
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override BsonType Type => default(BsonType);

		public BsonRegex(string pattern, string options)
		{
		}
	}
}
