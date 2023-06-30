using System;

[Serializable]
public class EnemyUnitData
{
	public EnemyType EnemyType;

	public int Index;

	public int Level;

	public int Hp;

	public AttackType AttackType;

	public float Damage;

	public float AttackSpeed;

	public float AttackRange;

	public DamageType DamageType;

	public float DamAoeRange;

	public float MoveSpeed;

	public int EXP;

	public bool IsBoss;

	public Enemy prefab;
}
