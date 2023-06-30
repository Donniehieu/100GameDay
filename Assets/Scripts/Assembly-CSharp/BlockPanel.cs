using UnityEngine;

public class BlockPanel : BaseUI
{
	[SerializeField]
	private ItemBlock[] ItemBlocks;

	[SerializeField]
	private GameObject BlockList;

	[SerializeField]
	private Transform content;

	[SerializeField]
	private ItemBlock prefab;

	private bool isShow;

	private float time;

	private void Start()
	{
	}

	public void SetInfor(ProcessBuild processBuild)
	{
	}

	private void Update()
	{
	}

	public void ShowBlockList()
	{
	}

	public new void Hide()
	{
	}
}
