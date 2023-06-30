using System;
using UnityEngine;

namespace Dossamer.PanZoom
{
	[Serializable]
	public struct AxisData
	{
		public Axis key;

		public Quaternion orientation;

		public bool IsOverriden;

		public bool IsEnabled;

		public bool IsSecondaryInputEnabled;

		public bool DoesSecondaryNeedTrigger;

		public string secondaryInputTrigger;

		public string customInputMethod;

		public string customSecondaryInputMethod;

		public InputMethod inputMethod;

		public InputMethod secondaryInputMethod;
	}
}
