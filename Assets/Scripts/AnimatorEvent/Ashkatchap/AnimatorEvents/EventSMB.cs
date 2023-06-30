using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Ashkatchap.AnimatorEvents
{
	public class EventSMB : StateMachineBehaviourExtended
	{
		public enum FilterByControllerMode : byte
		{
			Any = 0,
			MustMatch = 1,
			MustNotMatch = 2
		}

		public struct Data
		{
			public float fixedTime;

			public float lastNormalizedTime;
		}

		[Serializable]
		public struct Condition
		{
			public class IgnoreValueAttribute : Attribute
			{
			}

			public enum Type : byte
			{
				PARENTHESIS_CLOSE = 0,
				AND = 1,
				OR = 2,
				NOT = 3,
				MaxNTimesAfterStart = 4,
				MaxNTimesPerLoop = 5,
				OnExitEnd = 6,
				AfterEnterEnd = 7,
				AfterExitStart = 8,
				[IgnoreValue]
				OnNormalizedTime = 9,
				[IgnoreValue]
				OnNormalizedTimePerLoop = 10,
				[IgnoreValue]
				AfterNormalizedTime = 11,
				[IgnoreValue]
				AfterFixedTime = 12,
				[IgnoreValue]
				AfterNormalizedTimeStartTransition = 13,
				[IgnoreValue]
				AfterNormalizedTimeExitTransition = 14,
				ParameterEquals = 16,
				ParameterGreaterThanOrEquals = 17,
				ParameterGreaterThan = 21,
				ParameterLessThan = 22,
				ParameterLessThanOrEquals = 23,
				ParameterNotEquals = 24,
				DelegateCondition = 18,
				AND_GROUP = 19,
				OR_GROUP = 20,
				LayerEquals = 25,
				LayerNotEquals = 26,
				LayerGreaterThan = 27,
				LayerLessThan = 28,
				LayerGreaterThanOrEquals = 29,
				LayerLessThanOrEquals = 30,
				LayerWeightEquals = 31,
				LayerWeightNotEquals = 32,
				LayerWeightGreaterThan = 33,
				LayerWeightLessThan = 34,
				LayerWeightGreaterThanOrEquals = 35,
				LayerWeightLessThanOrEquals = 36,
				[IgnoreValue]
				AfterNormalizedTimePerLoop = 37,
				OnEnterStart = 38,
				OnEnterEnd = 39,
				OnExitStart = 40,
				BeforeEnterEnd = 47,
				BeforeExitStart = 48,
				[IgnoreValue]
				BeforeNormalizedTime = 51,
				[IgnoreValue]
				BeforeFixedTime = 52,
				[IgnoreValue]
				BeforeNormalizedTimeStartTransition = 53,
				[IgnoreValue]
				BeforeNormalizedTimeExitTransition = 54,
				[IgnoreValue]
				BeforeNormalizedTimePerLoop = 77
			}

			public delegate bool ConditionDelegate(Animator animator, int layerIndex, AnimatorStateInfo stateInfo, State prev, State now, Data data, Entry.Data entryData);

			internal const int BeforeCondTypeOffset = 40;

			public Type type;

			public float value;

			public int parameterHash;

			internal AnimatorControllerParameterType parameterType;

			public ConditionDelegate conditionDelegate;

			public static readonly KeyValuePair<string, Condition[]>[] Prepared;

			public Condition(Type type)
			{
			}

			public Condition(Type type, float value)
			{
			}

			public Condition(Type type, int parameterHash, float value)
			{
			}

			public Condition(ConditionDelegate conditionDelegate)
			{
			}
		}

		[Serializable]
		public struct Action
		{
			public enum Type : byte
			{
				CallEvent = 0,
				SendMessage = 1,
				SetParameter = 2
			}

			public enum SetParamMode : byte
			{
				Replace = 0,
				Add = 1,
				Sub = 2,
				Mul = 3,
				Div = 4,
				Mod = 5,
				Max = 6,
				Min = 7
			}

			public Type type;

			public byte mode;

			public int eventId;

			public System.Action callback;

			public string functionName;

			internal AnimatorControllerParameterType parameterType;

			public int parameterHash;

			public double value;

			public Action(int eventId)
			{
			}

			public Action(System.Action callback)
			{
			}

			public Action(string functionName)
			{
			}

			public Action(string functionName, float value)
			{
			}

			public Action(int parameterHash, float value, SetParamMode setParameterMode = SetParamMode.Replace)
			{
			}

			public void Execute(EventSMB eSMB, float layerWeight, Animator animator)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public class Entry
		{
			public struct Data
			{
				public float lastExecutedFixedTime;

				public float lastExecutedNormalizedTime;

				public int executionCountSinceStart;

				public int executionCountSinceLoop;

				public static readonly Data New;
			}

			[SerializeField]
			private short preparedConditionsIndex;

			[SerializeField]
			private Color color;

			[Tooltip("List of conditions that need to be met to be able to execute the actions.")]
			public List<Condition> conditions;

			[Tooltip("List of extra conditions that need to be met to be able to execute the actions.")]
			public List<Condition> conditionsExtra;

			public List<Action> actions;

			[NonSerialized]
			internal TinyArray2<Data> dataPerEntry;

			public Entry(short preparedConditionsIndex = -1)
			{
			}

			public void Reset()
			{
			}

			public Entry Clone()
			{
				return null;
			}
		}

		public static bool AllConditionsEvaluateToFalse;

		public List<RuntimeAnimatorController> controllers;

		public FilterByControllerMode controllerOkIfFound;

		public static EventSMB CurrentlyExecutingEventSMB;

		public static Entry CurrentlyExecutingEntry;

		public List<Entry> entries;

		private Data[] data;

		[NonSerialized]
		private AnimatorParametersCache parametersCache;

		private static List<Condition> TmpConditionsForBeforeCondTypes;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init()
		{
		}

		protected override void InitData(byte dataIndex)
		{
		}

		public override void StateUpdate(Animator animator, ref AnimatorStateInfo stateInfo, int layerIndex, State prev, State now, byte dataIndex)
		{
		}

		private bool EvaluateConditions(Entry entry, List<Condition> conditions, Animator animator, int layerIndex, ref AnimatorStateInfo stateInfo, State prev, State now, ref Data data, ref Entry.Data entryData)
		{
			return false;
		}

		private bool RecursiveEvaluateConditions(Entry entry, List<Condition> conditions, ref int index, Animator animator, int layerIndex, ref AnimatorStateInfo stateInfo, State prev, State now, ref Data data, ref Entry.Data entryData, bool groupOr = false, bool debugResult = true)
		{
			return false;
		}

		[Conditional("DEBUG")]
		private void DebugResult(List<Condition> conditions, int index, bool resultStep)
		{
		}

		private void TryExecute(Entry entry, Animator animator, int layerIndex, ref AnimatorStateInfo stateInfo, ref Data data, ref Entry.Data entryData)
		{
		}

		private void SetParamValue(Animator animator, double value, ref AnimatorControllerParameterType parameterType, int parameterHash)
		{
		}

		private double GetParamValue(Animator animator, ref AnimatorControllerParameterType parameterType, int parameterHash)
		{
			return 0.0;
		}

		private void ParameterTypeGet(ref AnimatorControllerParameterType _type, Animator animator, int parameterHash)
		{
		}
	}
}
