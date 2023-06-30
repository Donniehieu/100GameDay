using System.Collections.Generic;
using UnityEngine;

namespace Autotiles3D
{
	[CreateAssetMenu(menuName = "Autotiles3D/TileGroup")]
	public class Autotiles3D_TileGroup : ScriptableObject, ISerializationCallbackReceiver
	{
		public List<Autotiles3D_Tile> Tiles;

		private Dictionary<int, Autotiles3D_Tile> _map;

		private Dictionary<string, Autotiles3D_Tile> _nameMap;

		public Autotiles3D_Tile GetTile(int id)
		{
			return null;
		}

		public Autotiles3D_Tile GetTileByIndex(int index)
		{
			return null;
		}

		public Autotiles3D_Tile GetTile(string name)
		{
			return null;
		}

		public void UpdateTilesWithGroupName()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}
	}
}
