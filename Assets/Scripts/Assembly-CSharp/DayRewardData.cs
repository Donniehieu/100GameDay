using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "DayRewardData", menuName = "GameData/DayRewardData", order = 1)]
public class DayRewardData : SerializedScriptableObject
{
	public Dictionary<int, List<DayRewardUnitData>> DayRewards;

	public List<DayRewardUnitData> GetDayReward(int day)
	{
		return null;
	}
}
