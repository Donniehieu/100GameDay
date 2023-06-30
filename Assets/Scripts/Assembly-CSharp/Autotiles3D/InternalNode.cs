using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Autotiles3D
{
	[Serializable]
	public class InternalNode
	{
		public Autotiles3D_TileLayer Layer;

		public Vector3Int InternalPosition;

		public Quaternion LocalRotation;

		[FormerlySerializedAs("Block")]
		[SerializeField]
		private Autotiles3D_BlockBehaviour _block;

		[SerializeField]
		private GameObject _instance;

		[SerializeField]
		private string _group;

		[SerializeField]
		private string _tileName;

		[SerializeField]
		private int _tileID;

		[SerializeField]
		private int _ruleID;

		public int TileID => 0;

		public int RuleID => 0;

		public string TileGroupName => null;

		public string TileName => null;

		public GameObject Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Autotiles3D_BlockBehaviour Block => null;

		public void SetRuleID(int ruleId)
		{
		}

		public InternalNode(Autotiles3D_TileLayer layer, string group, string tileName, int tileID, Vector3Int internalPosition, Quaternion localRotation, GameObject instance = null)
		{
		}

		public void UpdateTileInfo(int tileID, string tileName, string group)
		{
		}
	}
}
