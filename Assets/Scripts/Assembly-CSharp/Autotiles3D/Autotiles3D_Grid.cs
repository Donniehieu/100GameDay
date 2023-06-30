using System;
using System.Collections.Generic;
using UnityEngine;

namespace Autotiles3D
{
	public class Autotiles3D_Grid : MonoBehaviour
	{
		public LevelSize GridSize;

		[Min(0f)]
		public int Height;

		[Min(0f)]
		public int Width;

		[Min(0f)]
		public float Unit;

		public List<Autotiles3D_TileLayer> TileLayers;

		[SerializeField]
		private int _LayerIndex;

		public Action<EventType, Event, Vector3> OnGridSelection;

		public Action<EventType, Event, Vector3> OnGridHover;

		public int LayerIndex
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public void SetLayerIndex(int index)
		{
		}

		public bool IsExceedingLevelGrid(Vector3 internalPosition)
		{
			return false;
		}

		public List<Autotiles3D_BlockBehaviour> GetBlocks(Vector3Int internalPosition)
		{
			return null;
		}

		public Vector3 ToWorldPoint(Vector3 internalPosition)
		{
			return default(Vector3);
		}

		public Vector3 ToWorldDirection(Vector3 internalDirection)
		{
			return default(Vector3);
		}
	}
}
