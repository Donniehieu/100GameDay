using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	internal class RootFilter : PathFilter
	{
		public static readonly RootFilter Instance;

		private RootFilter()
		{
		}

		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings? settings)
		{
			return null;
		}
	}
}
