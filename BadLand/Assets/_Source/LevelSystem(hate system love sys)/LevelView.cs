using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelView : MonoBehaviour
{
  [SerializeField] private GameObject pausePanel;
  
  public void PauseGame()
  {
    Time.timeScale = 0f;
    pausePanel.gameObject.SetActive(true);
  }

  public void Continue()
  {
    Time.timeScale = 1f;
    pausePanel.gameObject.SetActive(false);
  }

  public void Restart()
  {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
