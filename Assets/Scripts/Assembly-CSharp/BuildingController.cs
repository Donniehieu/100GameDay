using System.Collections.Generic;
using BigBear.Core.Runtime.Singleton;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildingController : Singleton<BuildingController>
{
	[SerializeField]
	private BuildingStatus BuildingStatus;

	private Dictionary<int, BuildingBase> buildings;

	[SerializeField]
	private Tilemap tilemap;

	[SerializeField]
	private Vector2Int SizeMap;

	private BlockType[,] map;

	public BuildingBase Fortress;

	private BuildingType buildingType;

	private BuildingGround buildingground;

	private Vector3Int posInt;

	private Vector2Int size;

	private bool status;

	private BlockType[,] blockTypes;

	private RaycastHit[] hitBuilding;

	private RaycastHit[] hitGround;

	private Vector3Int posMoveEnd;

	public override void Init()
	{
	}

	private void Start()
	{
	}

	public Vector3 GetPositionEnemy()
	{
		return default(Vector3);
	}

	private void ChangeMap(Vector2Int pos, Vector2Int size, BlockType status)
	{
	}

	private (bool, BlockType[,]) StatusMap(Vector2Int pos, Vector2Int size)
	{
		return default((bool, BlockType[,]));
	}

	public void CreateMap()
	{
	}

	public void StartBatle()
	{
	}

	private void LoadBuilding()
	{
	}

	public void ReBuiltBuilding(BuildingBase building)
	{
	}

	private BuildingBase Spawnbuilding(BuildingUnitProfiler profile)
	{
		return null;
	}

	public BuildingBase AddBuilding(BuildingType type, Vector2Int pos)
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnSelectBulding()
	{
	}

	public void BuyBuilding(BuildingType type)
	{
	}

	public void MoveBuilding(Vector3Int dir)
	{
	}

	public bool OkBuy()
	{
		return false;
	}

	public void CloseBuy()
	{
	}

	public void ResetState()
	{
	}

	public BuildingController()
	{
		((Singleton<T>)(object)this)._002Ector();
	}
}
