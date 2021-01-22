using UnityEngine;

namespace Asteroids
{
    public class GameController : MonoBehaviour
    {
        private ListExecuteObject _interactiveObject;
        private CameraController _cameraController;
        private InputController _inputController;
        private Player _player;
        private Attack _attack;
        private Camera _camera;
        private Ship _ship;
        
        
        private void Awake()
        {
            _interactiveObject = new ListExecuteObject();
            
            _player = FindObjectOfType<Player>();
            
            _attack = _player.GetComponentInChildren<Attack>();
            _interactiveObject.AddExecuteObject(_attack);

            _inputController = new InputController(_player);
            _interactiveObject.AddExecuteObject(_inputController);
            
            _camera = Camera.main;
            _cameraController = new CameraController(_player, _camera);
            _interactiveObject.AddExecuteObject(_cameraController);
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObject.Length; i++)
            {
                var interactiveObject = _interactiveObject[i];
            
                if (interactiveObject == null)
                {
                    continue;
                }
                
                interactiveObject.Execute();
            }
        }
    }
}