using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class GroupCreateResult : ResultBase, IGroupCreateResult, IResult
	{
		public const string IDKey = "id";

		public string GroupId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GroupCreateResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
