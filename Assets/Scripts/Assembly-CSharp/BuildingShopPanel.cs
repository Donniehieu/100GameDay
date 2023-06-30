using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingShopPanel : BaseUI
{
	[SerializeField]
	private Transform content;

	[SerializeField]
	private ItemBuildingShop itembuildingshop;

	private List<ItemBuildingShop> itemShops;

	[SerializeField]
	private AnimationElement listItems;

	[SerializeField]
	private AnimationElement buyPanel;

	[SerializeField]
	private AnimationElement upgradePanel;

	[SerializeField]
	private Button btUpgrade;

	[SerializeField]
	private TextMeshProUGUI txBuildingName;

	[SerializeField]
	private TextMeshProUGUI txgoldUpgrade;

	private Action buycomplete;

	private BuildingBase buildingUpgrade;

	private bool isShow;

	private void Start()
	{
	}

	public void SetInfor()
	{
	}

	public void ShowBuyPanel(Action buycomplete)
	{
	}

	public void CloseBuy()
	{
	}

	public void OkBuy()
	{
	}

	public void OnUpgrade(BuildingBase _buildingBase)
	{
	}

	public void OnInfor()
	{
	}

	public void ShowPanelUpgrade()
	{
	}

	public void BackToHome()
	{
	}
}
