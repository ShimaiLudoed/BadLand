using LevelSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LevelSystem
{
    public class Game 
    {
        private GameObject _pausePanel;
        private LevelBuild _levelBuild;
        private Difficult _difficulty;

        public Game(Difficult difficult, GameObject pausePanel, LevelBuild level)
        {
            _levelBuild = level;
            _pausePanel=pausePanel; 
            _difficulty = difficult;
        }

        public void PauseGame()
        {
            Time.timeScale = 0f;
            _pausePanel.gameObject.SetActive(true);
        }

        public void Continue()
        {
            Time.timeScale = 1f;
            _pausePanel.gameObject.SetActive(false);
        }

        public void Restart()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void StartGame()
        {
            _difficulty.LoadDifficulty();
            _levelBuild.GenerateLevel();
        }

        public void FinishGame()
        {
            //_difficulty.IncreaseDifficulty();
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
