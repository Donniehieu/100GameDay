using UnityEngine;

public class BuildingBase : MonoBehaviour
{
	protected BuildingUnitProfiler profiler;

	protected BuildingUnitData data;

	protected ProcessBuild processbuild;

	protected BuildingAction buildingAction;

	private GameObject prefab;

	public TroopType TroopType;

	public BuildingUnitProfiler Profiler => null;

	public BuildingUnitData Data => null;

	public ProcessBuild Processbuild => null;

	private void Awake()
	{
	}

	public virtual void SetInfor(BuildingUnitProfiler _profiler, BuildingUnitData _buildingData, GameObject _prefab)
	{
	}

	public TroopType GetTroopType(BuildingType buildingType)
	{
		return default(TroopType);
	}

	public virtual void Update()
	{
	}

	public virtual void BreakBuilding()
	{
	}

	public void RestoreBuilding()
	{
	}

	public void DestroyBuilding()
	{
	}

	private void SetupMeshCollider()
	{
	}
}
