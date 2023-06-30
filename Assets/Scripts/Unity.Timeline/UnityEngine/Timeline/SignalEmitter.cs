using System;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[CustomStyle("SignalEmitter")]
	[ExcludeFromPreset]
	public class SignalEmitter : Marker, INotification, INotificationOptionProvider
	{
		[SerializeField]
		private bool m_Retroactive;

		[SerializeField]
		private bool m_EmitOnce;

		[SerializeField]
		private SignalAsset m_Asset;

		public bool retroactive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool emitOnce
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SignalAsset asset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private PropertyName UnityEngine_002EPlayables_002EINotification_002Eid => default(PropertyName);

		private NotificationFlags UnityEngine_002ETimeline_002EINotificationOptionProvider_002Eflags => default(NotificationFlags);
	}
}
