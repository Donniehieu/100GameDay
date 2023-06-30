using System;
using System.Runtime.CompilerServices;

[Serializable]
public class HeroInfo
{
	public float Hp;

	public int Weapon
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

	public AttackType AttackType
	{
		[CompilerGenerated]
		get
		{
			return default(AttackType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int Level
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

	public float TotalHp
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float AttackSpeed
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float AttackRange
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public DamageType DamageType
	{
		[CompilerGenerated]
		get
		{
			return default(DamageType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float DamAoeRange
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float MoveSpeed
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float Damage
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}
}
