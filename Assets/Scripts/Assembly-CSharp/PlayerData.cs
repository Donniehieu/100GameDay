using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "GameData/PlayerData", order = 1)]
public class PlayerData : SerializedScriptableObject
{
	public List<PlayerUnitData> Levels;

	public PlayerUnitData GetData(int level)
	{
		return null;
	}

	public PlayerUnitData GetDataByLevel(int level)
	{
		return null;
	}
}
