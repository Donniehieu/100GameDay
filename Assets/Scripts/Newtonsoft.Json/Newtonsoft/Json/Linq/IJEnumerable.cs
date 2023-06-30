using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Newtonsoft.Json.Linq
{
	[DefaultMember("Item")]
	public interface IJEnumerable<out T> : IEnumerable<T>, IEnumerable where T : notnull, JToken
	{
		IJEnumerable<JToken> Item { get; }
	}
}
