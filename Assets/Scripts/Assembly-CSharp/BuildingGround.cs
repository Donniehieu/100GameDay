using Sirenix.OdinInspector;
using UnityEngine;

public class BuildingGround : SerializedMonoBehaviour
{
	[SerializeField]
	private Transform group;

	[SerializeField]
	private BoxCollider boxCollider;

	[SerializeField]
	private Vector2Int size;

	[SerializeField]
	private Sprite _sprite;

	[SerializeField]
	private float alpha;

	public SpriteRenderer[,] blocks;

	private Vector2Int sizeBuilding;

	public void SetInfor(Vector2Int _sizeBuilding)
	{
	}

	public void GroundEffect(BlockType[,] blockTypes)
	{
	}

	public void Destroy()
	{
	}
}
