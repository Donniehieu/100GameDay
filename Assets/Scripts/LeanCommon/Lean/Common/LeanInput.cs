using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Lean.Common
{
	public static class LeanInput
	{
		private static Dictionary<KeyCode, Key> keyMapping;

		private static ButtonControl GetMouseButtonControl(int index)
		{
			return null;
		}

		private static ButtonControl GetButtonControl(KeyCode oldKey)
		{
			return null;
		}

		public static int GetTouchCount()
		{
			return 0;
		}

		public static void GetTouch(int index, out int id, out Vector2 position, out float pressure, out bool set)
		{
			id = default(int);
			position = default(Vector2);
			pressure = default(float);
			set = default(bool);
		}

		public static Vector2 GetMousePosition()
		{
			return default(Vector2);
		}

		public static bool GetDown(KeyCode oldKey)
		{
			return false;
		}

		public static bool GetPressed(KeyCode oldKey)
		{
			return false;
		}

		public static bool GetUp(KeyCode oldKey)
		{
			return false;
		}

		public static bool GetMouseDown(int index)
		{
			return false;
		}

		public static bool GetMousePressed(int index)
		{
			return false;
		}

		public static bool GetMouseUp(int index)
		{
			return false;
		}

		public static float GetMouseWheelDelta()
		{
			return 0f;
		}

		public static bool GetMouseExists()
		{
			return false;
		}

		public static bool GetKeyboardExists()
		{
			return false;
		}
	}
}
