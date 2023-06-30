using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class GetTournamentsResult : ResultBase, IGetTournamentsResult, IResult
	{
		public TournamentResult[] Tournaments
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

		internal GetTournamentsResult(ResultContainer resultContainer)
			: base(null)
		{
		}
	}
}
