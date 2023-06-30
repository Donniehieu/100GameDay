using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.Singleton;
using DG.Tweening;
using UnityEngine;

public class GamePlayController : Singleton<GamePlayController>
{
	[CompilerGenerated]
	private sealed class _003CHireHero_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GamePlayController _003C_003E4__this;

		public MercenaryUnitData unitData;

		private Collider[] _003Cresult_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CHireHero_003Ed__25(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public Config Config;

	public int indexWave;

	private Tween tweenCountdown;

	private List<DayUnitData> DayUnitDatas;

	public bool isLoadEnemy;

	public PlayerController PlayerController;

	public LayerMask MaskMap;

	public int CountEnemies;

	public int CountEnemiesDie;

	public StateGame StateGame;

	private bool loadedAllWave;

	public override void Init()
	{
	}

	private void Start()
	{
	}

	public void StartBattle()
	{
	}

	public void LoadDay()
	{
	}

	public void StartWave()
	{
	}

	public void LoadWave(IEnumerable<WaveUnitData> waveData)
	{
	}

	public void SpawnEnemy(WaveUnitData data)
	{
	}

	public void StopSpawnEnemies()
	{
	}

	public void NextWave()
	{
	}

	public Vector3 RandomPositionAreaPlayer(float radius)
	{
		return default(Vector3);
	}

	public Enemy PoolSpawnEnemy(Enemy prefabs, Vector3 position)
	{
		return null;
	}

	public void PoolDestroyEnemy(Enemy enemy)
	{
	}

	public Troop PoolSpawnTroop(Troop prefab, Vector3 position)
	{
		return null;
	}

	public Mercenary PoolSpawnMercenary(Mercenary prefab, Vector3 position)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHireHero_003Ed__25))]
	internal IEnumerator HireHero(MercenaryUnitData unitData)
	{
		return null;
	}

	internal void SetLose()
	{
	}

	public void SetHeroRevive()
	{
	}

	internal void ComplateDay()
	{
	}

	public bool IsClearAllEnemies()
	{
		return false;
	}

	public void NextDay()
	{
	}

	internal void RestartDay()
	{
	}

	public void DestroyAllEnemies()
	{
	}

	public GamePlayController()
	{
		((Singleton<T>)(object)this)._002Ector();
	}
}
