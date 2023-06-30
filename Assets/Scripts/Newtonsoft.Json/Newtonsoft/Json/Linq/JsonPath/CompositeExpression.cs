using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	internal class CompositeExpression : QueryExpression
	{
		public List<QueryExpression> Expressions
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

		public CompositeExpression(QueryOperator @operator)
			: base(default(QueryOperator))
		{
		}

		public override bool IsMatch(JToken root, JToken t, JsonSelectSettings? settings)
		{
			return false;
		}
	}
}
