using UnityEngine;

namespace Asteroids
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed ;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;

        public float Speed => _speed;
        public float Acceleration => _acceleration;
        public float HP => _hp;

        private Ship _ship;
        internal Ship Ship => _ship;


        private void Start()
        {
            var moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);
        }


        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp--;
            }
        }
    }
}
