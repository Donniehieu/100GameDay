using System.Collections.Generic;
using BigBear.Core.Runtime.Singleton;
using UnityEngine;
using com.bigbear.common;

public class MapController : Singleton<MapController>
{
	public List<BuildingAction> buildings;

	public Transform GroupEnemies;

	public Transform GroupBuildings;

	public Transform GroupAllies;

	public List<IAttackTarget> Enemies;

	public List<IAttackTarget> Allies;

	public GateController GateController;

	public override void Init()
	{
	}

	public void AddAlly(IAttackTarget attackTarget)
	{
	}

	public void AddEnemy(IAttackTarget attackTarget)
	{
	}

	public IAttackTarget QueryAllyFindMinDistance(Enemy enemy)
	{
		return null;
	}

	public IAttackTarget QueryBuildingFindMinDistance(Enemy enemy)
	{
		return null;
	}

	public IEnumerable<IAttackTarget> QueryEnemyFindInRange(Enemy enemy)
	{
		return null;
	}

	public IEnumerable<IAttackTarget> QueryMercenaryFindInRange(Mercenary merc)
	{
		return null;
	}

	public IEnumerable<IAttackTarget> QueryPlayerFindInRange(PlayerController player)
	{
		return null;
	}

	internal void Default()
	{
	}

	public bool CheckClearAllEnemies()
	{
		return false;
	}

	public void RemoveEnemy(Enemy enemy)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void CallbackDestroyEvent(DestroyEvent e)
	{
	}

	internal void PauseEnemies()
	{
	}

	public MapController()
	{
		((Singleton<T>)(object)this)._002Ector();
	}
}
