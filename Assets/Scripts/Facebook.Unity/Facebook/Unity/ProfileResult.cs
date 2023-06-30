using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class ProfileResult : ResultBase, IProfileResult, IResult
	{
		public const string ProfileKey = "profile";

		public Profile CurrentProfile
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

		internal ProfileResult(ResultContainer resultContainer)
			: base(null)
		{
		}
	}
}
