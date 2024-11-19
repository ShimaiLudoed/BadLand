using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] private CollisionDetector collisionDetector;
        private PlayerModel _playerModel;
        [SerializeField] private InputListener inputListener;
        private PlayerController _controller;
        [SerializeField] private PlayerView _playerView;

        private void Awake()
        {
            _playerModel = new PlayerModel(_playerView.Speed, _playerView.Force);
            _controller=new PlayerController(_playerView, _playerModel, collisionDetector);
            inputListener.Construct(_controller);
            collisionDetector.Construct(_controller);
        }
    }
}