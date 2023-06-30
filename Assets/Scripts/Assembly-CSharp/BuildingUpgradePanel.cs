using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUpgradePanel : BaseUI
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image iconUp;

	[SerializeField]
	private TextMeshProUGUI txName;

	[SerializeField]
	private TextMeshProUGUI txLevel;

	[SerializeField]
	private TextMeshProUGUI txLevelUp;

	[SerializeField]
	private TextMeshProUGUI txHp;

	[SerializeField]
	private TextMeshProUGUI txHpUp;

	[SerializeField]
	private TextMeshProUGUI txDamage;

	[SerializeField]
	private TextMeshProUGUI txDamageUp;

	[SerializeField]
	private TextMeshProUGUI txGold;

	[SerializeField]
	private Button btUpgrade;

	private BuildingBase buildingBase;

	private BuildingUnitData buidingdata;

	private BuildingUnitData buildingUp;

	private bool upgradeStatus;

	public void SetInfor(BuildingBase _buildingBase)
	{
	}

	public void Close()
	{
	}

	public void OnUpgrade()
	{
	}
}
