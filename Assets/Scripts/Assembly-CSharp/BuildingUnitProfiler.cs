using System;

[Serializable]
public class BuildingUnitProfiler
{
	public int ID;

	public BuildingType BuildingType;

	public int Level;

	public int HP;

	public int NumberBlockBuilt;

	public bool BuildingComplete;

	public int X;

	public int Y;

	public bool IsDestroy;

	public DateTime TimDestroy;
}
