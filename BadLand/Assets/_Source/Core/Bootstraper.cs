using PlayerSystem;
using LevelSystem;
using PlayerSystem;
using UnityEngine;
namespace Core
{
    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] private CollisionDetector collisionDetector;
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private InputListener inputListener;
        private PlayerModel _playerModel;
        private PlayerController _controller;
        private LevelController _level; 
        [SerializeField] private Game _game;
        private Difficult _difficult;
        
        private void Awake()
        {
            _playerModel = new PlayerModel(_playerView.Speed, _playerView.Force);
            _controller=new PlayerController(_playerView, _playerModel, collisionDetector);
            collisionDetector.Construct(_controller);
            _difficult = new Difficult();
            _game.Construct(_difficult);
            _level = new LevelController(_game,collisionDetector);
            inputListener.Construct(_controller,_level);
        }
        private void Start()
        {
            _game.StartGame();
        }
    }
}