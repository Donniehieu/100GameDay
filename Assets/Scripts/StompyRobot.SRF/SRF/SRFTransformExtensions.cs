using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SRF
{
	public static class SRFTransformExtensions
	{
		[CompilerGenerated]
		private sealed class _003CGetChildren_003Ed__0 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Transform _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Transform t;

			public Transform _003C_003E3__t;

			private int _003Ci_003E5__2;

			private Transform System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002ETransform_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetChildren_003Ed__0(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<Transform> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002ETransform_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[IteratorStateMachine(typeof(_003CGetChildren_003Ed__0))]
		public static IEnumerable<Transform> GetChildren(this Transform t)
		{
			return null;
		}

		public static void ResetLocal(this Transform t)
		{
		}

		public static GameObject CreateChild(this Transform t, string name)
		{
			return null;
		}

		public static void SetParentMaintainLocals(this Transform t, Transform parent)
		{
		}

		public static void SetLocals(this Transform t, Transform from)
		{
		}

		public static void Match(this Transform t, Transform from)
		{
		}

		public static void DestroyChildren(this Transform t)
		{
		}
	}
}
