using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Autotiles3D
{
	[Serializable]
	public class Autotiles3D_Tile
	{
		[SerializeField]
		private string _group;

		[SerializeField]
		private int _tileID;

		public GameObject Default;

		public List<GameObject> Randoms;

		public bool Random;

		[FormerlySerializedAs("DisplayName")]
		[SerializeField]
		private string _name;

		public List<Autotiles3D_Rule> Rules;

		[NonSerialized]
		private Autotiles3D_TileGroup cachedGroup;

		public string Tag => null;

		public string Name => null;

		public bool HasRules => false;

		public int TileID => 0;

		public string Group => null;

		public void ResetID()
		{
		}

		public void SetGroupName(string group)
		{
		}

		public bool HasAnyRandomizeEnabled()
		{
			return false;
		}

		public Autotiles3D_TileGroup GetGroup()
		{
			return null;
		}

		public Autotiles3D_Tile(string displayName)
		{
		}

		public Autotiles3D_Tile(Autotiles3D_Tile copy)
		{
		}

		public GameObject GetRandomDefault()
		{
			return null;
		}
	}
}
