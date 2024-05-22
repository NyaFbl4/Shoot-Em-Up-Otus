using UnityEngine;

namespace ShootEmUp
{
    public class AttackAgent : MonoBehaviour
    {
        [SerializeField] private GameObject _character;
        [SerializeField] private BulletSystem _bulletSystem;
        //[SerializeField] private BulletManager bulletManager;
        //[SerializeField] private MainBulletSystem _mainBulletSystem;
        [SerializeField] private BulletConfig _bulletConfig;

        private bool _fireRequired;

        public void Attack()
        {
            var weapon = this._character.GetComponent<WeaponComponent>();
            _fireRequired = true;

            if (_fireRequired)
            {
                _bulletSystem.FlyBulletByArgs(new BulletSystem.Args
                {
                    position = weapon.Position,
                    velocity = weapon.Rotation * Vector3.up * this._bulletConfig.speed,
                    color = this._bulletConfig.color,
                    physicsLayer = (int)this._bulletConfig.physicsLayer,
                    //physicsLayer = (int)PhysicsLayer.CHARACTER,
                    damage = this._bulletConfig.damage,
                    isPlayer = true
                });

                
                /*
                _bulletSystem.FlyBulletByArgs(new BulletSystem.Args
                {
                    isPlayer = true,
                    //physicsLayer = (int)this._bulletConfig.physicsLayer,
                    physicsLayer = (int)PhysicsLayer.CHARACTER,
                    color = this._bulletConfig.color,
                    damage = this._bulletConfig.damage,
                    position = weapon.Position,
                    velocity = weapon.Rotation * Vector3.up * this._bulletConfig.speed
                });
                */
                
                _fireRequired = false;
            }
        }
    }
}