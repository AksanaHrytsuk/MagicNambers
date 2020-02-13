using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenLoader : MonoBehaviour
{
    public void LoadNextLevel(int LevelIndex)
{
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex + 1);

}

    public void firstscene()
    {
    SceneManager.LoadScene(0);
    }
}

