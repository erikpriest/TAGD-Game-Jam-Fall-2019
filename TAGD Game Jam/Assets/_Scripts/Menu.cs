﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene("Test Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Help()
    {
        // Camera to Another Position
    }

    public void LoadMenu()
    {
        //Camera to (0, 0)
    }
}
