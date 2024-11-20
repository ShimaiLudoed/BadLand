using LevelSystem_hate_system_love_sys_;
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
        private LevelController _level;
        [SerializeField] private LevelView levelView;

        private void Awake()
        {
            _playerModel = new PlayerModel(_playerView.Speed, _playerView.Force);
            _controller=new PlayerController(_playerView, _playerModel, collisionDetector);
            _level = new LevelController(levelView);
            inputListener.Construct(_controller,_level);
            collisionDetector.Construct(_controller);
        }
    }
}