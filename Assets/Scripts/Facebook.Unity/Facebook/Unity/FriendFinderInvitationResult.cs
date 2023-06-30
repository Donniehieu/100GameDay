using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class FriendFinderInvitationResult : ResultBase, IFriendFinderInvitationResult, IResult
	{
		public const string InvitationsKey = "friends_invitations";

		public IList<FriendFinderInviation> Invitations
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

		internal FriendFinderInvitationResult(ResultContainer resultContainer)
			: base(null)
		{
		}
	}
}
