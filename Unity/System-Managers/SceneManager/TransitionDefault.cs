/*
* Copyright (C) Josh Y. - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited 
* Proprietary and confidential
* Written by Josh Y. <joyang112@gmail.com>, June 2017
*/

//Documentations:
//================================
//[HelpUrl("URL")] Allows user to set a link to a documentation for reference

//Libraries:
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libraries Assets for Unity Scene Transition/Management

public class SCRIPTNAMEGOESHERE : MonoBehaviour
{
    //================================
    #region Variables:
    [Header("Animation Settings:")]
    [Space]
    
    public Animator transition;
    public float transitionTime = 1f;

    #endregion

    //================================

    #region Methods:
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    //[Space]
    #endregion

    //================================

    #region RNG Systems:
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    #endregion
    //================================
}