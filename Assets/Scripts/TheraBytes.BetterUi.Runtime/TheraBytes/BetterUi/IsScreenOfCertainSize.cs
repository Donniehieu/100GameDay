using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	[Serializable]
	public class IsScreenOfCertainSize : IScreenTypeCheck, IIsActive
	{
		public enum ScreenMeasure
		{
			Width = 0,
			Height = 1,
			Diagonal = 2
		}

		public enum UnitType
		{
			Inches = 0,
			Centimeters = 1
		}

		public const float DEFAULT_SMALL_THRESHOLD = 4.7f;

		public const float DEFAULT_LARGE_THRESHOLD = 7.6f;

		[SerializeField]
		private ScreenMeasure measureType;

		[SerializeField]
		private UnitType unitType;

		[SerializeField]
		private float minSizeInInches;

		[SerializeField]
		private float maxSizeInInches;

		[SerializeField]
		private bool isActive;

		public ScreenMeasure MeasureType
		{
			get
			{
				return default(ScreenMeasure);
			}
			set
			{
			}
		}

		public UnitType Units
		{
			get
			{
				return default(UnitType);
			}
			set
			{
			}
		}

		public float MinSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IsScreenOfCertainSize()
		{
		}

		public IsScreenOfCertainSize(float minHeighInInches, float maxHeightInInches)
		{
		}

		public bool IsScreenType()
		{
			return false;
		}
	}
}
