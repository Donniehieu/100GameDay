using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterSelectable.html")]
	[AddComponentMenu("Better UI/Controls/Better Selectable", 30)]
	public class BetterSelectable : Selectable, IBetterTransitionUiElement
	{
		[SerializeField]
		private List<Transitions> betterTransitions;

		public List<Transitions> BetterTransitions => null;

		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}
	}
}
