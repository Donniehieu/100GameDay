using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class LocaleResult : ResultBase, ILocaleResult, IResult
	{
		public string Locale
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

		internal LocaleResult(ResultContainer resultContainer)
			: base(null)
		{
		}
	}
}
