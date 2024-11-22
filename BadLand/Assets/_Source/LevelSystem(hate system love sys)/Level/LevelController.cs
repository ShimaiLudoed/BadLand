
namespace LevelSystem_hate_system_love_sys_
{
    public class LevelController
    {
        private readonly Game _levelView;

        public LevelController(Game levelView, Difficult difficult)
        {
            _levelView = levelView;
        }

        public void Pause()
        {
            _levelView.PauseGame();
        }

        public void Continue()
        {
            _levelView.Continue();
        }

        public void Restart()
        {
            _levelView.Restart();
        }
    }
}
