using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "DayData", menuName = "GameData/DayData", order = 1)]
public class DayData : SerializedScriptableObject
{
	public Dictionary<int, List<DayUnitData>> Days;

	public List<DayUnitData> GetWaves(int day)
	{
		return null;
	}
}
