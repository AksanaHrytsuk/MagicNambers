﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenLoader : MonoBehaviour
{
    public void LoadNextLevel()
{
        SceneManager.LoadScene("Game");

}
}
