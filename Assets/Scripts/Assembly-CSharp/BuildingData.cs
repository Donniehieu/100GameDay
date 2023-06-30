using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingData", menuName = "Game Data/BuildingData", order = 1)]
public class BuildingData : SerializedScriptableObject
{
	public Dictionary<BuildingType, List<BuildingUnitData>> Buildings;

	public BuildingUnitData GetBuildingData(BuildingType buildingType, int Level)
	{
		return null;
	}

	public bool MaxLevel(BuildingUnitProfiler profiler)
	{
		return false;
	}
}
