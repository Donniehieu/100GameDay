using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DoozyUI;
using UnityEngine;

[RequireComponent(typeof(UIElement))]
public class BaseUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitToShow_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public BaseUI _003C_003E4__this;

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
		public _003CWaitToShow_003Ed__11(int _003C_003E1__state)
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

	[SerializeField]
	protected UIElement uiElement;

	public UIElement UiElement => null;

	private void OnValidate()
	{
	}

	public bool IsVisible()
	{
		return false;
	}

	public virtual void OnInAnimationStart()
	{
	}

	public virtual void OnInAnimationFinish()
	{
	}

	public virtual void OnOutAnimationStart()
	{
	}

	public virtual void OnOutAnimationFinish()
	{
	}

	public void CloseUIElement()
	{
	}

	public void Show()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitToShow_003Ed__11))]
	public IEnumerator WaitToShow(float waitTime)
	{
		return null;
	}

	public void Hide()
	{
	}
}
