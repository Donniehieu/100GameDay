using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.bigbear.common
{
	public class Hero : MonoBehaviour, IAttackTarget
	{
		public HeroAction ActionControl
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

		public HeroBehaviour Behaviour
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

		public Damageable Damageable
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

		public DamageDealer DamageDealer
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

		public int Level => 0;

		public TeamType Team
		{
			[CompilerGenerated]
			get
			{
				return default(TeamType);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int EnemyMask
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string TargetTag
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IAttackTarget TargetEnemy
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public HeroInfo HeroInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void Init()
		{
		}

		private void Update()
		{
		}

		public void SetInfo(TeamType _team, HeroInfo _heroInfo)
		{
		}

		public virtual void ResetInfo()
		{
		}

		public virtual void StartBattle()
		{
		}

		public virtual void StopBattle(bool isWin)
		{
		}

		public virtual void Destroy()
		{
		}

		public virtual void EventAttack()
		{
		}

		public Transform GetTransform()
		{
			return null;
		}

		public IDamageable GetDamageable()
		{
			return null;
		}

		public virtual bool IsReady()
		{
			return false;
		}

		public virtual bool IsDie()
		{
			return false;
		}

		public virtual void OnDie()
		{
		}

		public virtual TargetType GetTargetType()
		{
			return default(TargetType);
		}

		public virtual bool CanAction()
		{
			return false;
		}
	}
}
