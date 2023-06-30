using System;
using UnityEngine;

[Serializable]
public class HeroUnitData
{
	public GameObject unitPrefab;

	public int level;

	public float hp;

	public AttackType attackType;

	public float attackRange;

	public DamageType damageType;

	public float damageAoeRange;

	public float damage;

	public float attackSpeed;

	public float moveSpeed;

	public HeroUnitData()
	{
	}

	public HeroUnitData(HeroUnitData other)
	{
	}

	public HeroUnitData(HeroInfo heroInfo, bool isInfor = false)
	{
	}
}
