
namespace LevelSystem_hate_system_love_sys_
{
  public class LevelController
  {
    private readonly LevelView _levelView;

    public LevelController(LevelView levelView)
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
