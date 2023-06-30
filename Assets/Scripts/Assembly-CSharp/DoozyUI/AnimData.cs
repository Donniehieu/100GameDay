using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class AnimData : ScriptableObject
	{
		public string presetCategory;

		public string presetName;

		public Anim data;

		public bool LoadDefaultValues => false;

		public AnimData(Anim.AnimationType aType)
		{
		}
	}
}
