using UnityEngine;

namespace Autotiles3D
{
	public class Autotiles3D_BlockBehaviour : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private int _tileID;

		[SerializeField]
		[HideInInspector]
		private int _ruleID;

		[SerializeField]
		[HideInInspector]
		private string _tileName;

		[SerializeField]
		[HideInInspector]
		private string _group;

		[SerializeField]
		[HideInInspector]
		private Vector3Int _internalPosition;

		[SerializeField]
		[HideInInspector]
		private Quaternion _localRotation;

		[SerializeField]
		[HideInInspector]
		private bool _isBaked;

		private Autotiles3D_Grid _grid;

		private Autotiles3D_Anchor _anchor;

		public GameObject View;

		public string TileName => null;

		public int TileID => 0;

		public string GroupName => null;

		public int RuleID => 0;

		public Vector3Int InternalPosition
		{
			get
			{
				return default(Vector3Int);
			}
			set
			{
			}
		}

		public Quaternion LocalRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Autotiles3D_Grid Grid => null;

		public Autotiles3D_Anchor Anchor => null;

		public bool IsBaked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void ToggleView(bool enable)
		{
		}

		public InternalNode GetInternalNode()
		{
			return null;
		}

		public void OnInstanceUpdate(InternalNode node)
		{
		}
	}
}
