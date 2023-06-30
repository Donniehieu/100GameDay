using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Sprite Data", menuName = "Game Data/Sprite Data", order = 1)]
public class SpriteData : SerializedScriptableObject
{
	public Dictionary<BuildingType, Sprite[]> IconBuildings;

	public Dictionary<RewardType, Sprite> IconBlocks;

	public Material matbuildingalpha1;

	public Material matbuildingalpha05;

	public Material matbuildingexplosion;

	public Sprite GetIconBuilding(BuildingType type, int level)
	{
		return null;
	}

	public Sprite GetIconBlock(RewardType rewardType)
	{
		return null;
	}
}
