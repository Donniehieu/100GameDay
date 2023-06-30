using System;

[Serializable]
public class GameProfile
{
	public int Day;

	public int Challenge;

	public int Level;

	public float Exp;

	public float ExpNext;

	public WeaponType WeaponType;

	public int RankWeapon;

	public void Default()
	{
	}

	public bool IsNextLevel(float exp)
	{
		return false;
	}
}
