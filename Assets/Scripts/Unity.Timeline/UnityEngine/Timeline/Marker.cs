using System.Runtime.CompilerServices;

namespace UnityEngine.Timeline
{
	public abstract class Marker : ScriptableObject, IMarker
	{
		[SerializeField]
		[Tooltip("Time for the marker")]
		[TimeField(TimeFieldAttribute.UseEditMode.ApplyEditMode)]
		private double m_Time;

		public TrackAsset parent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public double time
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		private void UnityEngine_002ETimeline_002EIMarker_002EInitialize(TrackAsset parentTrack)
		{
		}

		public virtual void OnInitialize(TrackAsset aPent)
		{
		}
	}
}
