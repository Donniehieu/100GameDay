using System.Reflection;

namespace UnityEngine.Rendering
{
	[DefaultMember("Item")]
	public interface IBitArray
	{
		uint capacity { get; }

		bool allFalse { get; }

		bool allTrue { get; }

		bool Item { get; set; }

		string humanizedData { get; }

		IBitArray BitAnd(IBitArray other);

		IBitArray BitOr(IBitArray other);

		IBitArray BitNot();
	}
}
