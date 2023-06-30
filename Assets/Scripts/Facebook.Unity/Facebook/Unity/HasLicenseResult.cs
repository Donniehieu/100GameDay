using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class HasLicenseResult : ResultBase, IHasLicenseResult, IResult
	{
		public bool HasLicense
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

		public HasLicenseResult(ResultContainer resultContainer)
			: base(null)
		{
		}
	}
}
