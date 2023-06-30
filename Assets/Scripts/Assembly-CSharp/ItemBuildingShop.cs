using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemBuildingShop : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private TextMeshProUGUI txName;

	[SerializeField]
	private TextMeshProUGUI txStatus;

	[SerializeField]
	private TextMeshProUGUI txGold;

	[SerializeField]
	private GameObject mask;

	private BuildingShopProfiler profile;

	private int GoldNeed;

	public void Init(BuildingType buildingtype)
	{
	}

	public void LoadInfor()
	{
	}

	public void OnBuy()
	{
	}

	public void BuyComplete()
	{
	}
}
