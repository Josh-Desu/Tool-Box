/*
* Copyright (C) Josh Y. - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited 
* Proprietary and confidential
* Written by Josh Y. <joyang112@gmail.com>, June 2017
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausesystem : MonoBehaviour
{
    //================================
    #region Variables:
    [Header("Pause Settings: ")]
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;

    #endregion

    //================================

    #region Unity Methods:

    private void Update()
    {
        //Change this to accomodate for user inputs, this is just a temporary input setting for demonstration purposes.
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if(GamePaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    #endregion

    //================================

    #region Methods:
    /*
    private void methodName()
    {
        //Do Something()
    }
    */
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("_mainmenu");
    }

    //[Space]
    #endregion

    //================================
}
