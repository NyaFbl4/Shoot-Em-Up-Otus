using UnityEngine;

namespace ShootEmUp
{
    public sealed class EnemyPosition : MonoBehaviour
    {
        [SerializeField] private Transform[] _spawnPositions;
        [SerializeField] private Transform[] _attackPositions;

        public Transform RandomSpawnPosition()
        {
            return RandomTransform(this._spawnPositions);
        }

        public Transform RandomAttackPosition()
        {
            return RandomTransform(this._attackPositions);
        }

        private static Transform RandomTransform(Transform[] transforms)
        {
            var index = Random.Range(0, transforms.Length);
            return transforms[index];
        }
    }
}