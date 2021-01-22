using UnityEngine;

namespace Asteroids
{
    public class CameraController: IExecute
    {
        private Player _player;
        private Camera _mainCamera;
        
        public CameraController(Player player, Camera mainCamera)
        {
            _player = player;
            _mainCamera = mainCamera;
        }

        public void Execute()
        {
            var direction = Input.mousePosition - _mainCamera.WorldToScreenPoint(_player.transform.position);
            _player.Ship.Rotation(direction);
        }
    }
}