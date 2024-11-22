using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficult 
{
    public int LevelDificulty {  get; private set; }

    public void IncreaseDifficulty(int lvlDifficulty)
    {
        LevelDificulty = lvlDifficulty;
        PlayerPrefs.SetInt("PlayerDifficulty", LevelDificulty);
    }

}
