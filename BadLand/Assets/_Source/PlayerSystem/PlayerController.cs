using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerController
    {
        private readonly PlayerView _playerView;
        private readonly PlayerModel _playerModel;
        private readonly CollisionDetector _collisionDetector;

        public PlayerController(PlayerView playerView, PlayerModel playerModel, CollisionDetector collisionDetector)
        {
            _playerView = playerView;
            _playerModel = playerModel;
            _collisionDetector = collisionDetector;
            _collisionDetector.OnPlayerDead += Death;
        }
        
        public void Death()
        {
            _playerView.Death();
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
        public void ChangeMass(float multy)
        {
            _playerView.ChangeMass(multy); 
        }
    }
}