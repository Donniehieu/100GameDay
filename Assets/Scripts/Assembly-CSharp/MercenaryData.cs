using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "MercenaryData", menuName = "GameData/MercenaryData", order = 1)]
public class MercenaryData : SerializedScriptableObject
{
	public Dictionary<MercenaryType, List<MercenaryUnitData>> Mercenaries;

	public MercenaryUnitData GetMercenaryData(int level)
	{
		return null;
	}
}
