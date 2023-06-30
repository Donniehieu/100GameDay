using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Block ADS Data", menuName = "Game Data/Block ADS Data", order = 1)]
public class BlockADSData : SerializedScriptableObject
{
	[SerializeField]
	private Dictionary<int, Dictionary<RewardType, int>> BlockADS;

	public int GetQuantityBlock(RewardType rewardType)
	{
		return 0;
	}
}
