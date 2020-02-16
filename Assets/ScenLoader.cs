using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenLoader : MonoBehaviour
{
  public void LoadNextLevel()
  {
    int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(activeSceneIndex + 1);

  }

  public void firstscene()
  {
    SceneManager.LoadScene(0);
  }
  public void ExitGame()
  {
    Application.Quit();
    Debug.Log("Exit");
  }
}

