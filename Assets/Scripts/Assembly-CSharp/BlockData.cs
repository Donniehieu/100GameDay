using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Block Data", menuName = "Game Data/Block Data", order = 1)]
public class BlockData : SerializedScriptableObject
{
	[SerializeField]
	private Dictionary<RewardType, int> BlockDatas;

	public int GetGoldBlock(RewardType rewardType)
	{
		return 0;
	}
}
