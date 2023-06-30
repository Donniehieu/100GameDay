using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveData", menuName = "GameData/WaveData", order = 1)]
public class WaveData : SerializedScriptableObject
{
	public Dictionary<int, List<WaveUnitData>> Waves;

	public IEnumerable<WaveUnitData> GetWave(int day, int wave)
	{
		return null;
	}

	internal int GetTotalEnemy(int day)
	{
		return 0;
	}
}
