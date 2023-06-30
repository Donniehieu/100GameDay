using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Ashkatchap.AnimatorEvents
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Animator))]
	public class AnimatorEvent : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		public class EventElement
		{
			public string name;

			public int id;

			public UnityEvent action;
		}

		private static readonly Dictionary<Animator, List<AnimatorEvent>> ByAnimator;

		private static readonly Stack<List<AnimatorEvent>> Pool;

		public List<EventElement> events;

		private readonly Dictionary<int, EventElement> runtimeEventsById;

		private readonly Dictionary<string, EventElement> runtimeEventsByName;

		private List<EventElement> runtimeEventsCache;

		private Animator animator;

		private static readonly List<AnimatorEvent> Dummy;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public bool AddEventRuntime(EventElement ev)
		{
			return false;
		}

		public bool DelEventRuntime(EventElement ev)
		{
			return false;
		}

		public static List<AnimatorEvent> Get(Animator animator)
		{
			return null;
		}

		public void CallEvent(string name)
		{
		}

		public bool TryCallEvent(string name)
		{
			return false;
		}

		public bool CallEvent(int id)
		{
			return false;
		}

		public bool CallEvent(ref int id, string functionName)
		{
			return false;
		}

		public EventElement AddEventForEditor()
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
