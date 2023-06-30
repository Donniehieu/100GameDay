using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Selectable")]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanSelectable")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class LeanSelectable : MonoBehaviour
	{
		[Serializable]
		public class LeanFingerEvent : UnityEvent<LeanFinger>
		{
			public LeanFingerEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		public static LinkedList<LeanSelectable> Instances;

		public bool DeselectOnUp;

		public bool HideWithFinger;

		public bool IsolateSelectingFingers;

		[SerializeField]
		[FormerlySerializedAs("OnSelect")]
		private LeanFingerEvent onSelect;

		[FormerlySerializedAs("onSelectSet")]
		[FormerlySerializedAs("OnSelectSet")]
		[SerializeField]
		private LeanFingerEvent onSelectUpdate;

		[FormerlySerializedAs("OnSelectUp")]
		[SerializeField]
		private LeanFingerEvent onSelectUp;

		[SerializeField]
		[FormerlySerializedAs("OnDeselect")]
		private UnityEvent onDeselect;

		[SerializeField]
		private bool isSelected;

		[NonSerialized]
		private List<LeanFinger> selectingFingers;

		[NonSerialized]
		private LinkedListNode<LeanSelectable> node;

		private static List<LeanSelectable> tempSelectables;

		public LeanFingerEvent OnSelect => null;

		public LeanFingerEvent OnSelectUpdate => null;

		public LeanFingerEvent OnSelectUp => null;

		public UnityEvent OnDeselect => null;

		public bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsSelectedRaw => false;

		public static int IsSelectedCount => 0;

		public static int IsSelectedRawCount => 0;

		public LeanFinger SelectingFinger => null;

		public List<LeanFinger> SelectingFingers => null;

		private bool AnyFingersSet => false;

		public static event Action<LeanSelectable> OnEnableGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<LeanSelectable> OnDisableGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<LeanSelectable, LeanFinger> OnSelectGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<LeanSelectable, LeanFinger> OnSelectSetGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<LeanSelectable, LeanFinger> OnSelectUpGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<LeanSelectable> OnDeselectGlobal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static List<LeanFinger> GetFingers(bool ignoreIfStartedOverGui, bool ignoreIfOverGui, int requiredFingerCount = 0, LeanSelectable requiredSelectable = null)
		{
			return null;
		}

		public static void GetSelected(List<LeanSelectable> list)
		{
		}

		public static void Cull(int maxCount)
		{
		}

		public static LeanSelectable FindSelectable(LeanFinger finger)
		{
			return null;
		}

		public static void ReplaceSelection(LeanFinger finger, List<LeanSelectable> selectables)
		{
		}

		public bool IsSelectedBy(LeanFinger finger)
		{
			return false;
		}

		public bool GetIsSelected(bool raw)
		{
			return false;
		}

		[ContextMenu("Select")]
		public void Select()
		{
		}

		public void Select(LeanFinger finger)
		{
		}

		[ContextMenu("Deselect")]
		public void Deselect()
		{
		}

		public static void DeselectAll()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private static void BuildTempSelectables(LeanFinger finger)
		{
		}

		private static void HandleFingerUpdate(LeanFinger finger)
		{
		}

		private static void HandleFingerUp(LeanFinger finger)
		{
		}

		private static void HandleFingerInactive(LeanFinger finger)
		{
		}
	}
}
