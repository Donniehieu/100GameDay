using System.Collections.Generic;

namespace Facebook.Unity
{
	public interface IPayloadResult : IResult
	{
		IDictionary<string, string> Payload { get; }
	}
}
