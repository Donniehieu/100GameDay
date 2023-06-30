using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingProcessPanel : BaseUI
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private TextMeshProUGUI txName;

	[SerializeField]
	private TextMeshProUGUI txLevel;

	[SerializeField]
	private TextMeshProUGUI txGold;

	[SerializeField]
	private Button btGold;

	[SerializeField]
	private GameObject btFinish;

	[SerializeField]
	private GameObject g_textMiss;

	[SerializeField]
	private ItemBuildingProcess[] itemBuildingProcesses;

	private BuildingBase buildingBase;

	private int GoldNeed;

	private Dictionary<RewardType, int> NumberBlocks;

	public void SetInfor(BuildingBase _buildingBase)
	{
	}

	public void BuyBlockByGold()
	{
	}

	public void FinishNow()
	{
	}

	public void NoThank()
	{
	}
}
