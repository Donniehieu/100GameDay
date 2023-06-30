using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.bigbear.common
{
	public class HeroBehaviour : MonoBehaviour
	{
		protected Hero hero;

		public AiState curAiState;

		protected HeroDeadEvent HeroDeadEvent;

		public AIBehaviour AiBehaviour
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public void OnUpdate(float dt)
		{
		}

		internal void ResetInfo()
		{
		}

		internal void SetInfo()
		{
		}

		public virtual void InitAiBehaviour()
		{
		}

		public virtual void StartCalculate()
		{
		}

		internal void StopCalculate()
		{
		}

		public void PauseCalculate(bool isPause)
		{
		}

		public void Die()
		{
		}

		public void Attack()
		{
		}

		public void Init()
		{
		}

		public void TakeImpact()
		{
		}
	}
}
