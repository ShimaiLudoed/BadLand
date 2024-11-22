using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game
{
    private GameObject _pausePanel;

    public int Level;

    public Game (GameObject pausePanel, int level)
    {
        _pausePanel = pausePanel;
        Level = level;
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
}
