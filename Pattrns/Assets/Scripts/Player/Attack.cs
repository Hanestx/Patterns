using UnityEngine;


namespace Asteroids
{
    public class Attack : MonoBehaviour, IExecute
    {
        
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        
        public void Execute()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
                temAmmunition.AddForce(_barrel.up * _force);
            }
        }
    }
}