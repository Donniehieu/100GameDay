using System.Collections.Generic;
using UnityEngine.UI;

public class PanelLose : BaseUI
{
	public List<ItemDayReward> DayRewardList;

	public Button btnWatchAds;

	private List<DayRewardUnitData> Data;

	private float Percent;

	private int xReward;

	public void SetInfo(List<DayRewardUnitData> data, float percent)
	{
	}

	public string SetText(int gold)
	{
		return null;
	}

	public void OnClickWatchAds()
	{
	}

	public void Reward()
	{
	}

	public void OnClickNoThanks()
	{
	}
}
