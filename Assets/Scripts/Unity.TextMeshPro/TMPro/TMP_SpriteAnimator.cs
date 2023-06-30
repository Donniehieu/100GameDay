using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TMPro
{
	[DisallowMultipleComponent]
	public class TMP_SpriteAnimator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoSpriteAnimationInternal_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TMP_SpriteAnimator _003C_003E4__this;

			public int start;

			public int end;

			public TMP_SpriteAsset spriteAsset;

			public int currentCharacter;

			public int framerate;

			private int _003CcurrentFrame_003E5__2;

			private TMP_CharacterInfo _003CcharInfo_003E5__3;

			private int _003CmaterialIndex_003E5__4;

			private int _003CvertexIndex_003E5__5;

			private TMP_MeshInfo _003CmeshInfo_003E5__6;

			private float _003CbaseSpriteScale_003E5__7;

			private float _003CelapsedTime_003E5__8;

			private float _003CtargetTime_003E5__9;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
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
			public _003CDoSpriteAnimationInternal_003Ed__7(int _003C_003E1__state)
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
		}

		private Dictionary<int, bool> m_animations;

		private TMP_Text m_TextComponent;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void StopAllAnimations()
		{
		}

		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
		}

		[IteratorStateMachine(typeof(_003CDoSpriteAnimationInternal_003Ed__7))]
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			return null;
		}
	}
}
