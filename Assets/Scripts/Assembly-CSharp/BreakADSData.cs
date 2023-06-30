using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Break ADS Data", menuName = "Game Data/Break ADS Data", order = 1)]
public class BreakADSData : SerializedScriptableObject
{
	public Dictionary<int, List<List<BreadADSUnit>>> UnitADS;

	public (RewardType, int) GetRewardBreak()
	{
		return default((RewardType, int));
	}
}
