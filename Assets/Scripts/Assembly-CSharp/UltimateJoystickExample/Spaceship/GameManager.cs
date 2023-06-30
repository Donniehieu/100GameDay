using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UltimateJoystickExample.Spaceship
{
	public class GameManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSpawnTimer_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameManager _003C_003E4__this;

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
			public _003CSpawnTimer_003Ed__19(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CFadeDeathScreen_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameManager _003C_003E4__this;

			private Color _003CimageColor_003E5__2;

			private Color _003CtextColor_003E5__3;

			private float _003Ct_003E5__4;

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
			public _003CFadeDeathScreen_003Ed__24(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CShakeCamera_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private Vector2 _003CorigPos_003E5__2;

			private float _003Ct_003E5__3;

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
			public _003CShakeCamera_003Ed__27(int _003C_003E1__state)
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

		private static GameManager instance;

		[Header("Prefabs")]
		public GameObject astroidPrefab;

		public GameObject debrisPrefab;

		public GameObject explosionPrefab;

		public GameObject playerExplosionPrefab;

		private bool spawning;

		[Header("Spawning")]
		public float spawnTimeMin;

		public float spawnTimeMax;

		public int startingAsteroids;

		[Header("Score")]
		public Text scoreText;

		private int score;

		public int asteroidPoints;

		public int debrisPoints;

		[Header("Game Over")]
		public Image gameOverScreen;

		public Text gameOverText;

		public static GameManager Instance => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnTimer_003Ed__19))]
		private IEnumerator SpawnTimer()
		{
			return null;
		}

		private void SpawnAsteroid()
		{
		}

		public void SpawnDebris(Vector3 pos)
		{
		}

		public void SpawnExplosion(Vector3 pos)
		{
		}

		public void ShowDeathScreen()
		{
		}

		[IteratorStateMachine(typeof(_003CFadeDeathScreen_003Ed__24))]
		private IEnumerator FadeDeathScreen()
		{
			return null;
		}

		public void ModifyScore(bool isDebris)
		{
		}

		private void UpdateScoreText()
		{
		}

		[IteratorStateMachine(typeof(_003CShakeCamera_003Ed__27))]
		private IEnumerator ShakeCamera()
		{
			return null;
		}
	}
}
