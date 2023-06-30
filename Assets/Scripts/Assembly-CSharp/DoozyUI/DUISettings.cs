using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class DUISettings : ScriptableObject
	{
		private static DUISettings _instance;

		public bool autoExpandEnabledFeatures;

		public bool UIButton_allowMultipleClicks;

		public float UIButton_disableButtonInterval;

		public bool UIButton_deselectButtonOnClick;

		public bool UIButton_Inspector_HideOnClick;

		public bool UIButton_useOnClickAnimations;

		public bool UIButton_waitForOnClickAnimation;

		public UIButton.SingleClickMode UIButton_singleClickMode;

		public bool UIButton_customOnClickSound;

		public UIButton.ButtonAnimationType UIButton_onClickAnimationType;

		public string UIButton_onClickPunchPresetCategory;

		public string UIButton_onClickPunchPresetName;

		public bool UIButton_loadOnClickPunchPresetAtRuntime;

		public string UIButton_onClickStatePresetCategory;

		public string UIButton_onClickStatePresetName;

		public bool UIButton_loadOnClickStatePresetAtRuntime;

		public bool UIButton_Inspector_HideNormalLoop;

		public string UIButton_normalLoopPresetCategory;

		public string UIButton_normalLoopPresetName;

		public bool UIButton_loadNormalLoopPresetAtRuntime;

		public static DUISettings Instance => null;
	}
}
