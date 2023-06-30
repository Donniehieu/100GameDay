using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Ashkatchap.AnimatorEvents
{
	public static class Extensions
	{
		private static string[] POpen;

		private static string[] PClose;

		public static string ToStringFull(this IList<EventSMB.Condition> conditions, AnimatorControllerParameter[] parameters, bool isDark = false)
		{
			return null;
		}

		private static string ParamColor(bool isDark)
		{
			return null;
		}

		private static void Recursive(StringBuilder str, AnimatorControllerParameter[] parameters, IList<EventSMB.Condition> conditions, ref int index, bool isDark, bool groupOr = false, int rLevel = 0)
		{
		}

		private static AnimatorControllerParameter FindParam(AnimatorControllerParameter[] parameters, int hash)
		{
			return null;
		}

		private static void Operand(StringBuilder str, int id, bool isDark)
		{
		}

		public static string GetFullPath(Animator animator)
		{
			return null;
		}

		public static string ToStringFull(this AnimatorStateInfo info)
		{
			return null;
		}

		public static string ToStringFull(this AnimatorClipInfo info)
		{
			return null;
		}

		public static string ToStringFull(this AnimatorTransitionInfo info)
		{
			return null;
		}
	}
}
