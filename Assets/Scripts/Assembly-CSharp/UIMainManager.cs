using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.Singleton;
using DoozyUI;
using UnityEngine;

public class UIMainManager : Singleton<UIMainManager>
{
	[SerializeField]
	private UIElement background;

	public UIGamePlay UIGamePlay;

	public HomePanel HomePanel;

	public PlayerInforPanel PlayerInforPanel;

	public GoldPanel GoldPanel;

	public BuildingShopPanel BuildingPanel;

	public BuildingUpgradePanel BuildingUpgrade;

	public BuildingProcessPanel BuildingProcessPanel;

	public BlockPanel BlockPanel;

	public PanelLose PanelLose;

	public PanelCongratulation PanelCongratulation;

	public PanelHire PanelHire;

	public PanelGetFree PanelGetFree;

	public PanelHeroLevelUp PanelHeroLevelUp;

	public PanelReviveHero PanelReviveHero;

	public ADSBreakPanel ADSBreakPanel;

	public Queue<UIElement> QueuePopup
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void Init()
	{
	}

	private void Start()
	{
	}

	public UIMainManager()
	{
		((Singleton<T>)(object)this)._002Ector();
	}
}
