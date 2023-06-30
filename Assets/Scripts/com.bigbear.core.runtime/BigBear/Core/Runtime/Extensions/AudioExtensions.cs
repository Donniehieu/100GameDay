using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BigBear.Core.Runtime.Extensions
{
	public static class AudioExtensions
	{
		[CompilerGenerated]
		private sealed class _003CPlayOneShotDelayed_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float aDelay;

			public AudioSource anAudioSource;

			public AudioClip anAudioClip;

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
			public _003CPlayOneShotDelayed_003Ed__0(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CPlayOneShotDelayed_003Ed__0))]
		public static IEnumerator PlayOneShotDelayed(this AudioSource anAudioSource, AudioClip anAudioClip, float aDelay)
		{
			return null;
		}

		public static AudioType PlatformAudioType()
		{
			return default(AudioType);
		}

		public static string PlatformAudioExtension()
		{
			return null;
		}

		public static string PlatformFileProtocol()
		{
			return null;
		}

		public static float ToDecibel(this float linear)
		{
			return 0f;
		}

		public static float ToLinear(this float dB)
		{
			return 0f;
		}
	}
}
