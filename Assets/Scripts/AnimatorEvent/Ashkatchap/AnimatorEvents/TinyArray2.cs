using System.Reflection;

namespace Ashkatchap.AnimatorEvents
{
	[DefaultMember("Item")]
	public struct TinyArray2<T>
	{
		public T e0;

		public T e1;

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}
	}
}
