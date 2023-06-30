using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "TroopData", menuName = "GameData/TroopData", order = 1)]
public class TroopData : SerializedScriptableObject
{
	public List<TroopUnitData> Troops;

	public TroopUnitData GetTroopData(TroopType troopType, int level)
	{
		return null;
	}
}
