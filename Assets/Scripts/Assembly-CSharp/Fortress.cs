using UnityEngine;

public class Fortress : BuildingBase
{
	[SerializeField]
	private Transform pillar;

	[SerializeField]
	private ParticleSystem explosion;

	private Vector3 posT;

	private void Awake()
	{
	}

	public override void SetInfor(BuildingUnitProfiler _profiler, BuildingUnitData _buildingData, GameObject _prefab)
	{
	}

	public void OnStartBatle()
	{
	}

	public override void Update()
	{
	}

	public override void BreakBuilding()
	{
	}
}
