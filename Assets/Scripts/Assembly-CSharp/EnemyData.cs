using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/EnemyData", order = 1)]
public class EnemyData : SerializedScriptableObject
{
	public Dictionary<EnemyType, List<EnemyUnitData>> Enemies;

	public EnemyUnitData GetEnemyData(EnemyType enemyType, int Level)
	{
		return null;
	}
}
