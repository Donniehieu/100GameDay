using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "HeroData", menuName = "Data/HeroData", order = 0)]
public class HeroData : SerializedScriptableObject
{
	public List<HeroUnitData> unitList;
}
