using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class ProcessBuild : SerializedMonoBehaviour
{
	private BuildingBase BuildingBase;

	[SerializeField]
	private List<BuildingBlock> BuildingBlocks;

	public Dictionary<RewardType, int> NumberBlocks;

	public Dictionary<RewardType, int> NumberRemainBlocks;

	private BlockBuilding blockbuilding;

	public void SetInfor(BuildingBase _buildingBase)
	{
	}

	private void CreateBlockBuilding()
	{
	}

	public bool BuiltBlock()
	{
		return false;
	}

	public void FinishNow()
	{
	}
}
