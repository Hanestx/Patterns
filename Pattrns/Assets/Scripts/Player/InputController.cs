using System;
using UnityEngine;

namespace Asteroids
{
    internal sealed class InputController : IExecute
    {
        private readonly Player _player;
        private Camera _camera;

        public InputController(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _player.Ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _player.Ship.RemoveAcceleration();
            }
            
        }
    }
}