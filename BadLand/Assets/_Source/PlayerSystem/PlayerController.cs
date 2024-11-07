using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerController
    {
        private readonly PlayerView _playerView;
        private readonly PlayerModel _playerModel;

        public PlayerController(PlayerView playerView, PlayerModel playerModel)
        {
            _playerView = playerView;
            _playerModel = playerModel;
        }

        public void Move(Vector2 direction)
        {
            _playerView.Move(_playerModel.Speed, direction);
        }
        public void Jump()
        {
            _playerView.Jump(_playerModel.Force);
        }
        public void TiltCharacter(float horizontal)
        {
            _playerView.TiltCharacter(horizontal);
        }
    }
}