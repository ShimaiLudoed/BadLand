using UnityEngine;

namespace LevelSystem
{
    public class Difficult
    {
        public int LevelDificulty = 3;
        
        public void IncreaseDifficulty()
        {
            float level = LevelDificulty * 1.5f;
            LevelDificulty = (int) level;
            PlayerPrefs.SetInt("PlayerDifficulty", LevelDificulty);
            PlayerPrefs.Save();
        }
        public void LoadDifficulty()
        {
            LevelDificulty = PlayerPrefs.GetInt("PlayerDifficulty",LevelDificulty);
        }
    }
}
