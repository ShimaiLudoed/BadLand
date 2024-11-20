using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelView : MonoBehaviour
{
  [SerializeField] private GameObject pausePanel;

  public void PauseGame()
  {
    Time.timeScale = 0f;
    pausePanel.gameObject.SetActive(true);
  }
}
