using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Sirenix.Serialization.Utilities
{
	internal interface IImmutableList : IList, IEnumerable, ICollection
	{
	}
	[DefaultMember("Item")]
	internal interface IImmutableList<T> : IImmutableList, IList, IEnumerable, ICollection, IList<T>, ICollection<T>, IEnumerable<T>
	{
		new T Item { get; }
	}
}
