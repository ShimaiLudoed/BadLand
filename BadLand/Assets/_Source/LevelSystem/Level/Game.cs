using LevelSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LevelSystem
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameObject _startGame;
        [SerializeField] private GameObject _endGame;
        [SerializeField] private GameObject[] _pref;
        [SerializeField] private GameObject _pausePanel;
        private LevelBuild _levelBuild;
        private Difficult _difficulty;
        
        public void Construct (Difficult difficult)
        {
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
            _levelBuild = new LevelBuild(_pref,_difficulty.LevelDificulty,_endGame,_startGame);
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
