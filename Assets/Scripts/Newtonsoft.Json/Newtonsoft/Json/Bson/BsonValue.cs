namespace Newtonsoft.Json.Bson
{
	internal class BsonValue : BsonToken
	{
		private readonly object _value;

		private readonly BsonType _type;

		public object Value => null;

		public override BsonType Type => default(BsonType);

		public BsonValue(object value, BsonType type)
		{
		}
	}
}
