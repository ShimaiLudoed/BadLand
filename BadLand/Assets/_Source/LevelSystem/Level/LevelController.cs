using LevelSystem;

namespace LevelSystem
{
    public class LevelController
    {
        private readonly Game _game;
        private readonly CollisionDetector _collisionDetector;

        public LevelController(Game game, CollisionDetector collisionDetector)
        {
            _game = game;
            _collisionDetector = collisionDetector;
            _collisionDetector.OnPlayerFinish+=Finish;
        }

        public void Pause()
        {
            _game.PauseGame();
        }

        public void Continue()
        {
            _game.Continue();
        }

        public void Restart()
        {
            _game.Restart();
        }

        public void Finish()
        {
            _game.FinishGame();
        }
    }
}
