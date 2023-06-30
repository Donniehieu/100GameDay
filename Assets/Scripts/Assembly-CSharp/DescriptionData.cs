using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "Description Data", menuName = "Game Data/Description Data", order = 1)]
public class DescriptionData : SerializedScriptableObject
{
	[SerializeField]
	private Dictionary<BuildingType, DescriptionUnit> DescriptionBuilding;

	public DescriptionUnit GetDescriptionBuilding(BuildingType type)
	{
		return null;
	}
}
