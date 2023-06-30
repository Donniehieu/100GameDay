using UnityEngine;
using com.bigbear.common;

public class Tower : Hero
{
	public TeamType teamType;

	public Animator animator;

	public ParticleSystem effOnHit;

	public ParticleSystem effDie;

	public Collider colliderTower;

	public Transform root;

	public Transform trnGun;

	public Transform cannon;

	public override void StartBattle()
	{
	}

	public void SetAttackEnemy()
	{
	}

	public void TakeDamage(float damage, IDamageDealer _damageDealer)
	{
	}

	public void Die()
	{
	}

	public void PlayTakeDamageEffect(IDamageDealer damageDealer)
	{
	}
}
