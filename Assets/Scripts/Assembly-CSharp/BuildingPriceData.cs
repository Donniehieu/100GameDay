using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Building Price Data", menuName = "Game Data/Building Price Data", order = 1)]
public class BuildingPriceData : SerializedScriptableObject
{
	[SerializeField]
	private Dictionary<BuildingType, List<int>> Prices;

	public int GetPriceBuilding(BuildingType type, int Number)
	{
		return 0;
	}
}
