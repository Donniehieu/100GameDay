using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class AbortDialogResult : ResultBase, IDialogResult, IResult
	{
		public bool Success
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal AbortDialogResult(ResultContainer resultContainer)
			: base(null)
		{
		}
	}
}
