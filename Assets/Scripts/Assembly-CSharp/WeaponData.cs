using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "GameData/WeaponData", order = 1)]
public class WeaponData : SerializedScriptableObject
{
	public List<WeaponUnitData> Weapons;

	public WeaponUnitData GetWeaponData(WeaponType weaponType, int rank)
	{
		return null;
	}
}
