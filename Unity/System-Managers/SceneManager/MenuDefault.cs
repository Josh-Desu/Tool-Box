/*
* Copyright (C) Josh Y. - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited 
* Proprietary and confidential
* Written by Josh Y. <joyang112@gmail.com>, June 2017
*/
//Documentations:
//================================
//[HelpUrl("URL")] Allows user to set a link to a documentation for reference
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libraries Assets for Unity Scene Transition/Management

public class mainmenu : MonoBehaviour
{
    // Set this up by adding to button functions for player to transition scene
    [Header("Menu Settings: ")]
    public string transitiontoScene;
    //================================

    public void loadScene_1()
    {
        SceneManager.LoadScene("Scene_1");
        //Debug.Log("Map/scene loaded!");
    }
    public void loadScene_2()
    {
        SceneManager.LoadScene("transitiontoScene");
        //Debug.Log("Map/scene loaded!");
    }
    public void loadScene_3()
    {
        SceneManager.LoadScene(1);
        //Debug.Log("Map/scene loaded!");
    }

    public void Quit()
    {
        Application.Quit();
        //Debug.Log("Game has Quit!");
    }

}