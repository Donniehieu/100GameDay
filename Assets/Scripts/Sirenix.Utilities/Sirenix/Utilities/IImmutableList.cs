using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Sirenix.Utilities
{
	public interface IImmutableList : IList, IEnumerable, ICollection
	{
	}
	[DefaultMember("Item")]
	public interface IImmutableList<T> : IImmutableList, IList, IEnumerable, ICollection, IList<T>, ICollection<T>, IEnumerable<T>
	{
		new T Item { get; }
	}
}
