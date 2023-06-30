using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[AddComponentMenu("Better UI/Controls/Better Scrollbar", 30)]
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterScrollbar.html")]
	public class BetterScrollbar : Scrollbar, IBetterTransitionUiElement
	{
		[SerializeField]
		private List<Transitions> betterTransitions;

		public List<Transitions> BetterTransitions => null;

		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}
	}
}
