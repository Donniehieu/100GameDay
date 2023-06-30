using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class LoopData : ScriptableObject
	{
		public string presetCategory;

		public string presetName;

		public Loop data;

		public bool LoadDefaultValues => false;
	}
}
