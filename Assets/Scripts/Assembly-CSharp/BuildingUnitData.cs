using System;
using UnityEngine;

[Serializable]
public class BuildingUnitData
{
	public BuildingType BuildingType;

	public int Level;

	public int Gold;

	public DamageType DamageType;

	public Vector2Int Size;

	public int HP;

	public int TimeHealing;

	public int Damage;

	public int AtkRange;

	public Vector2Int BuildRange;

	public int EnemyGateMin;

	public int EnemyGateMax;

	public int GuardRange;

	public float AtkSpeed;

	public int AOERange;

	public int TroopCapicity;

	public GameObject prefab;

	public GameObject prefabFinish;
}
