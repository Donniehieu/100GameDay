using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class PunchData : ScriptableObject
	{
		public string presetCategory;

		public string presetName;

		public Punch data;

		public bool LoadDefaultValues => false;
	}
}
