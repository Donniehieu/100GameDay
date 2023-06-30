using System.Collections.Generic;
using UnityEngine;
using com.bigbear.common;

public class BuildingAction : MonoBehaviour, IAttackTarget
{
	private BuildingBase buildingBase;

	private IDamageable Damageable;

	private BoxCollider boxCollider;

	public Collider ColliderBuilding;

	[SerializeField]
	private List<MeshRenderer> meshRenders;

	[SerializeField]
	private List<ParticleSystem> fxExplosion;

	public void SetInfo()
	{
	}

	public void FxBreakBuilding()
	{
	}

	public void FxRestoreBuilding()
	{
	}

	public Transform GetTransform()
	{
		return null;
	}

	public IDamageable GetDamageable()
	{
		return null;
	}

	public bool IsDie()
	{
		return false;
	}

	public Vector3 RandomPositionSpawn()
	{
		return default(Vector3);
	}

	public TargetType GetTargetType()
	{
		return default(TargetType);
	}

	public void EffectFlash()
	{
	}
}
