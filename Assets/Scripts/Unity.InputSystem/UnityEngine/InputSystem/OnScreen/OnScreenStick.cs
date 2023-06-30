using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Serialization;

namespace UnityEngine.InputSystem.OnScreen
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.4/manual/OnScreen.html#on-screen-sticks")]
	[AddComponentMenu("Input/On-Screen Stick")]
	public class OnScreenStick : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[SerializeField]
		[FormerlySerializedAs("movementRange")]
		private float m_MovementRange;

		[InputControl(layout = "Vector2")]
		[SerializeField]
		private string m_ControlPath;

		private Vector3 m_StartPos;

		private Vector2 m_PointerDownPos;

		public float movementRange
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override string controlPathInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		private void Start()
		{
		}
	}
}
