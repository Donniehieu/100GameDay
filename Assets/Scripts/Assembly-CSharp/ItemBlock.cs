using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemBlock : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private TextMeshProUGUI txNumber;

	private RewardType rewardType;

	private void Awake()
	{
	}

	public void SetInfor(RewardType _rewardType)
	{
	}

	private void UpdateNumber(BlockChangedEvent e)
	{
	}

	public void OnDestroy()
	{
	}
}
