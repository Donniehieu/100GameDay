using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIGamePlay : BaseUI
{
	public TextMeshProUGUI txtDay;

	public TextMeshProUGUI txtCountdown;

	public TextMeshProUGUI txtReviveHp;

	private GameProfile gameProfile;

	public UIDayInfo dayInfo;

	public CanvasGroup CanvasInGame;

	public CanvasGroup CanvasPrevGame;

	public UltimateJoystick joystickMove;

	public UltimateJoystick joystickLook;

	public Slider SliderHp;

	public void SetInfo(GameProfile profile)
	{
	}

	private void Start()
	{
	}

	public void SetState(StateGame state)
	{
	}

	public void OnClickStartBattle()
	{
	}

	public void ShowAllText()
	{
	}

	internal void SetTextCountdown(int curr)
	{
	}

	public new void Show()
	{
	}

	public new void Hide()
	{
	}

	public void ReviveHero(int Time, Action callback)
	{
	}

	public void SetHP(float hp, float maxHp)
	{
	}
}
