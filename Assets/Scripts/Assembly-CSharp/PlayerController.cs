using UnityEngine;
using com.bigbear.common;

public class PlayerController : Hero
{
	public PlayerUnitData UnitData;

	public PlayerUnitData NextData;

	public WeaponUnitData weaponData;

	public WeaponController WeaponController;

	public CharacterManager CharacterManager;

	public GameProfile profile;

	public int AttackType;

	[SerializeField]
	private Animator animator;

	private Collider[] colliders;

	private const string KEY = "GameProfile";

	public void Reload()
	{
	}

	public void SetInfo()
	{
	}

	public void SetInfoAnimation(float moveSpeed, float attackSpeed)
	{
	}

	public HeroInfo GetHeroInfo()
	{
		return null;
	}

	public void AddExp(float exp)
	{
	}

	public void NextLevel()
	{
	}

	public void ReloadUI()
	{
	}

	public override TargetType GetTargetType()
	{
		return default(TargetType);
	}

	public void Load()
	{
	}

	private void Save()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void TestAttack()
	{
	}

	public override void EventAttack()
	{
	}

	internal void FindTarget()
	{
	}

	public void TakeImpact()
	{
	}

	public override void OnDie()
	{
	}

	private void OnEnable()
	{
	}

	private void CallbackHeroReviveEvent(HeroReviveEvent e)
	{
	}

	private void SetIdle()
	{
	}

	private void OnDisable()
	{
	}
}
