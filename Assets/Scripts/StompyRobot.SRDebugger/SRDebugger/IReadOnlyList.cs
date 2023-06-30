using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace SRDebugger
{
	[DefaultMember("Item")]
	public interface IReadOnlyList<T> : IEnumerable<T>, IEnumerable
	{
		int Count { get; }

		T Item { get; }
	}
}
