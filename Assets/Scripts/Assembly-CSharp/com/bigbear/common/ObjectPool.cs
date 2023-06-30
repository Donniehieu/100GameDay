using System.Collections.Generic;
using UnityEngine;

namespace com.bigbear.common
{
	[CreateAssetMenu(fileName = "ObjectPool", menuName = "Data/ObjectPool", order = 0)]
	public class ObjectPool : ScriptableObject
	{
		[SerializeField]
		private BlockBuilding BlockBuilding;

		[SerializeField]
		private BuildingGround BuildingGround;

		public List<GameObject> projectiles;

		public List<Effect> effects;

		public List<GameObject> UIPrefabs;

		public Hero InstantiateHero(GameObject heroPrefab, Vector3 position)
		{
			return null;
		}

		public void DestroyHero(GameObject heroPrefab, GameObject go)
		{
		}

		public Hero InstantiateBoss(GameObject bossPrefab, Vector3 position)
		{
			return null;
		}

		public void DestroyBoss(GameObject bossPrefab, GameObject go)
		{
		}

		public Hero InstantiateEnemy(GameObject enemyPrefab, Vector3 position)
		{
			return null;
		}

		public void DestroyEnemy(GameObject enemyPrefab, GameObject go)
		{
		}

		public Projectile InstantiateProjectile(ProjectileType projectileType, Vector3 position)
		{
			return null;
		}

		public void DestroyProjectile(ProjectileType projectileType, GameObject gameObject)
		{
		}

		public Effect InstantiateEffect(EffectType effectType, Vector3 position)
		{
			return null;
		}

		public void DestroyEffect(EffectType effectType, GameObject destroyedGo)
		{
		}

		internal Arrow InstantiateCanonBullet()
		{
			return null;
		}

		public GameObject InstantiateBuilding(GameObject prefabs, Transform parent)
		{
			return null;
		}

		public void DestroyBuilding(GameObject prefab, GameObject go)
		{
		}

		public BlockBuilding InstantiateBlockBuilding()
		{
			return null;
		}

		public void DestroyBlockBuilding(GameObject go)
		{
		}

		public BuildingGround InstantiateBuildingGround()
		{
			return null;
		}

		public void DestroyBuildingGround(GameObject go)
		{
		}
	}
}
