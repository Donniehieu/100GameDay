using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Autotiles3D
{
	public class Autotiles3D_Anchor : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("TileID")]
		private int _tileID;

		[HideInInspector]
		public GameObject BakedParent;

		[HideInInspector]
		[SerializeField]
		private int _childCount;

		[HideInInspector]
		[SerializeField]
		private int _bakeCount;

		public int Childcount => 0;

		public int BakeCount => 0;

		public int TileID => 0;

		public Autotiles3D_TileLayer Layer => null;

		public void IncreaseBlockCount()
		{
		}

		public void DecreaseBlockCount()
		{
		}

		public void SetBakeCount(int count)
		{
		}

		public void SetTileID(int tileID)
		{
		}

		public List<Autotiles3D_BlockBehaviour> GetBlocks()
		{
			return null;
		}

		public void ToggleViews(bool enable, bool includeBaked = false)
		{
		}
	}
}
