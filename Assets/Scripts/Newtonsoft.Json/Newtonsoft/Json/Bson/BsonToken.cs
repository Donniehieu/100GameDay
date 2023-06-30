using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal abstract class BsonToken
	{
		public abstract BsonType Type { get; }

		public BsonToken Parent
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

		public int CalculatedSize
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
	}
}
