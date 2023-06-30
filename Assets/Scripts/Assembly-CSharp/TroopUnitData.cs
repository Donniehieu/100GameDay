using System;

[Serializable]
public class TroopUnitData
{
	public TroopType TroopType;

	public int Level;

	public float TrainingTime;

	public float Hp;

	public float RegenHp;

	public AttackType AttackType;

	public float Damage;

	public float AttackSpeed;

	public float AttackRange;

	public DamageType DamageType;

	public float DamAoeRange;

	public float MoveSpeed;

	public Troop prefab;
}
