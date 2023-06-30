using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Building Unlock Data", menuName = "Game Data/Building Unlock Data", order = 1)]
public class BuildingUnlockData : SerializedScriptableObject
{
	[SerializeField]
	private Dictionary<int, List<BuildingUnlockUnit>> BuildingUnlockUnits;

	public List<BuildingUnlockUnit> GetBuildingUnlock(int fortressLevel)
	{
		return null;
	}
}
