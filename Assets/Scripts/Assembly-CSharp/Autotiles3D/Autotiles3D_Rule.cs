using System;
using System.Collections.Generic;
using UnityEngine;

namespace Autotiles3D
{
	[Serializable]
	public class Autotiles3D_Rule
	{
		public bool IsActive;

		public GameObject Object;

		public bool Random;

		public List<GameObject> Randoms;

		public Relation[] Relations;

		public bool[] AllowRotation;

		[SerializeField]
		private int _ruleID;

		public int RuleID => 0;

		public Autotiles3D_Rule()
		{
		}

		public Autotiles3D_Rule(Autotiles3D_Rule copy)
		{
		}

		public GameObject GetRandomObject()
		{
			return null;
		}
	}
}
