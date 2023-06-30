using System.Collections.Generic;
using UnityEngine;

public class BuildingProfiler
{
	public Dictionary<int, BuildingUnitProfiler> BuildingProfilers;

	public Dictionary<BuildingType, BuildingShopProfiler> BuildingShopProfilers;

	private void LoadDataBuildingShop()
	{
	}

	public void Save()
	{
	}

	public BuildingShopProfiler GetBuildingShopProfile(BuildingType type)
	{
		return null;
	}

	public void UnlockBuilding()
	{
	}

	public BuildingUnitProfiler AddBuilding(BuildingType buildingType, Vector2Int pos, int Level = 1)
	{
		return null;
	}
}
