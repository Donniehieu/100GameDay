using System.Collections.Generic;
using UnityEngine;

namespace Autotiles3D
{
	public class Autotiles3D_TileLayer : MonoBehaviour, ISerializationCallbackReceiver
	{
		public string LayerName;

		private Dictionary<Vector3Int, InternalNode> _internalNodes;

		public Dictionary<int, Autotiles3D_Anchor> Anchors;

		public Autotiles3D_TileGroup Group;

		private int _activeTileID;

		private Autotiles3D_Grid _Grid;

		[SerializeField]
		private List<Vector3Int> _NodesKeys;

		[SerializeField]
		private List<InternalNode> _NodesValues;

		[SerializeField]
		private List<int> _AnchorKeys;

		[SerializeField]
		private List<Autotiles3D_Anchor> _AnchorValues;

		public bool IsLayerEmpty => false;

		public List<Autotiles3D_Tile> Tiles => null;

		public int ActiveTileID => 0;

		public Autotiles3D_Grid Grid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ContainsKey(Vector3Int internalPosition)
		{
			return false;
		}

		public InternalNode GetInternalNode(Vector3Int internalPosition)
		{
			return null;
		}

		public List<Vector3Int> GetAllInternalPositions()
		{
			return null;
		}

		public List<InternalNode> GetAllInternalNodes()
		{
			return null;
		}

		public Autotiles3D_Anchor GetAnchor(int tileID)
		{
			return null;
		}

		public void SetActiveTileID(int tileID)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
