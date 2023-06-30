using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class MovementActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	public struct GameplayActions
	{
		private MovementActions m_Wrapper;

		public InputAction Movement => null;

		public InputAction Jump => null;

		public InputAction Camera => null;

		public InputAction Attack => null;

		public InputAction Ride => null;

		public bool enabled => false;

		public GameplayActions(MovementActions wrapper)
		{
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(GameplayActions set)
		{
			return null;
		}

		public void SetCallbacks(IGameplayActions instance)
		{
		}
	}

	public interface IGameplayActions
	{
		void OnMovement(InputAction.CallbackContext context);

		void OnJump(InputAction.CallbackContext context);

		void OnCamera(InputAction.CallbackContext context);

		void OnAttack(InputAction.CallbackContext context);

		void OnRide(InputAction.CallbackContext context);
	}

	private readonly InputActionMap m_Gameplay;

	private IGameplayActions m_GameplayActionsCallbackInterface;

	private readonly InputAction m_Gameplay_Movement;

	private readonly InputAction m_Gameplay_Jump;

	private readonly InputAction m_Gameplay_Camera;

	private readonly InputAction m_Gameplay_Attack;

	private readonly InputAction m_Gameplay_Ride;

	private int m_KeyboardSchemeIndex;

	private int m_GamePadSchemeIndex;

	private int m_MouseSchemeIndex;

	public InputActionAsset asset
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public InputBinding? bindingMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputDevice>? devices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

	public IEnumerable<InputBinding> bindings => null;

	public GameplayActions Gameplay => default(GameplayActions);

	public InputControlScheme KeyboardScheme => default(InputControlScheme);

	public InputControlScheme GamePadScheme => default(InputControlScheme);

	public InputControlScheme MouseScheme => default(InputControlScheme);

	public void Dispose()
	{
	}

	public bool Contains(InputAction action)
	{
		return false;
	}

	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		action = null;
		return 0;
	}
}
