using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls
{
	public class QuaternionControl : InputControl<Quaternion>
	{
		[InputControl(displayName = "X")]
		public AxisControl x
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

		[InputControl(displayName = "Y")]
		public AxisControl y
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

		[InputControl(displayName = "Z")]
		public AxisControl z
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

		[InputControl(displayName = "W")]
		public AxisControl w
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

		public QuaternionControl()
		{
			((InputControl<>)(object)this)._002Ector();
		}

		protected override void FinishSetup()
		{
		}

		public unsafe override Quaternion ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Quaternion);
		}

		public unsafe override void WriteValueIntoState(Quaternion value, void* statePtr)
		{
		}
	}
}
