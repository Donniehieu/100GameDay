using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class FBWindowsPurchaseManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadPictureFromUrl_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public RawImage itemImage;

		private Texture2D _003CUserPicture_003E5__2;

		private WWW _003Cwww_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadPictureFromUrl_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public FBWindowsLogsManager Logger;

	public GameObject ProductGameObject;

	public Transform CatalogPanelTarnsform;

	public Transform PurchasesPanelTarnsform;

	public void GetCatalogButton()
	{
	}

	private void ProcessGetCatalog(ICatalogResult result)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadPictureFromUrl_003Ed__6))]
	private IEnumerator LoadPictureFromUrl(string url, RawImage itemImage)
	{
		return null;
	}

	private void ProcessPurchase(IPurchaseResult result)
	{
	}

	public void GetPurchases()
	{
	}

	private void processPurchases(IPurchasesResult result)
	{
	}
}
