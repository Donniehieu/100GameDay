using UnityEngine;

namespace com.bigbear.common
{
	public interface IAttackTarget
	{
		Transform GetTransform();

		IDamageable GetDamageable();

		bool IsDie();

		TargetType GetTargetType();
	}
}
