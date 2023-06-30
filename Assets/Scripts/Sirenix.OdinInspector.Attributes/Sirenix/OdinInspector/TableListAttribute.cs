using System;
using System.Diagnostics;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public class TableListAttribute : Attribute
	{
		public int NumberOfItemsPerPage;

		public bool IsReadOnly;

		public int DefaultMinColumnWidth;

		public bool ShowIndexLabels;

		public bool DrawScrollView;

		public int MinScrollViewHeight;

		public int MaxScrollViewHeight;

		public bool AlwaysExpanded;

		public bool HideToolbar;

		public int CellPadding;

		[HideInInspector]
		[SerializeField]
		private bool showPagingHasValue;

		[SerializeField]
		[HideInInspector]
		private bool showPaging;

		public bool ShowPaging
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowPagingHasValue => false;

		public int ScrollViewHeight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
