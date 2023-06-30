using System.Collections.Generic;
using UnityEngine;

namespace MeshCombineStudio
{
	[ExecuteInEditMode]
	[DefaultExecutionOrder(-99999999)]
	public abstract class MCS_RemoveTris : MonoBehaviour
	{
		private HashSet<GameObjectLayer> gos;

		private bool hasRegistered;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Register(bool first)
		{
		}

		private void Init(MeshCombiner meshCombiner)
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Unregister()
		{
		}

		private void OnCombine(MeshCombiner meshCombiner)
		{
		}

		private void OnCombineReady(MeshCombiner meshCombiner)
		{
		}
	}
}
