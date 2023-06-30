using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Select")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanSelect")]
	public class LeanSelect : LeanSelectBase
	{
		public enum ReselectType
		{
			KeepSelected = 0,
			Deselect = 1,
			DeselectAndSelect = 2,
			SelectAgain = 3
		}

		public static LinkedList<LeanSelect> Instances;

		public int MaxSelectables;

		public ReselectType Reselect;

		public bool AutoDeselect;

		public bool SuppressMultipleSelectWarning;

		[NonSerialized]
		private LinkedListNode<LeanSelect> node;

		protected override void TrySelect(LeanFinger finger, Component component, Vector3 worldPosition)
		{
		}

		public void Select(LeanFinger finger, LeanSelectable selectable)
		{
		}

		[ContextMenu("Deselect All")]
		public void DeselectAll()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
