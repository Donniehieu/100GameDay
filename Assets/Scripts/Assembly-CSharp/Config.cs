using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Config", menuName = "Data/Config", order = 0)]
public class Config : ScriptableObject
{
	public DayData DayData;

	public DayRewardData DayRewardData;

	public MercenaryData MercenaryData;

	public EnemyData EnemyData;

	public PlayerData PlayerData;

	public WaveData WaveData;

	public WeaponData WeaponData;

	public TroopData TroopData;

	public List<DayRewardInfo> ListDayRewardInfo;

	public PlayerUnitData GetPlayerUnitData(int level)
	{
		return null;
	}

	public List<DayRewardUnitData> GetDayReward(int day)
	{
		return null;
	}
}
