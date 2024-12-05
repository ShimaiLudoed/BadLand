using PlayerSystem;
using LevelSystem;
using PlayerSystem;
using UnityEngine;
namespace Core
{
    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] private GameObject _startGame;
        [SerializeField] private GameObject _endGame;
        [SerializeField] private GameObject[] _pref;
        [SerializeField] private GameObject _pausePanel;
        [SerializeField] private CollisionDetector collisionDetector;
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private InputListener inputListener;
        private PlayerModel _playerModel;
        private PlayerController _controller;
        private LevelController _level; 
        private Game _game;
        private Difficult _difficult;
        private LevelBuild _levelBuild;
        
        private void Awake()
        {
            _playerModel = new PlayerModel(_playerView.Speed, _playerView.Force);
            _controller=new PlayerController(_playerView, _playerModel, collisionDetector);
            collisionDetector.Construct(_controller);
            _difficult = new Difficult();
            _levelBuild = new LevelBuild(_pref, _difficult.LevelDificulty, _endGame, _startGame);
            _game = new Game(_difficult,_pausePanel, _levelBuild);
            _level = new LevelController(_game,collisionDetector);
            inputListener.Construct(_controller,_level);
            
        }
        private void Start()
        {
            _game.StartGame();
        }
    }
}