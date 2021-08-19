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

public class destroySelf : MonoBehaviour, IPooledObject
{
    [Header("Destruction Settings:")]

    public float timer = 1.0f;
    public bool disableObject = false;
    public bool destroyObject = false;

    private bool startScript = false;
    private bool readyState = false;

    private void Awake()
    {
        //readyState = false;
    }
    public void OnObjectSpawn()
    {
        StartCoroutine(startTimer());
    }
    private void Update()
    {
        //if(startScript == false)
        //{
        //    StartCoroutine(startTimer());
        
        //}

        checkLoad();
    }
    //Destroy gameobject in scene to keep low load

    public void checkLoad()
    {
        if(disableObject == true && readyState == true)
        {
            gameObject.SetActive(false);
            readyState = false;
        }
        else if(destroyObject == true && readyState == true)
        {
            Destroy(gameObject);
            readyState = false;
        }
        else if(disableObject == true && destroyObject == true)
        {
            Debug.Log("Error in destroy/disable, more than 1 option selected...");
            return;
        }
    }

    //StartCoroutine(MethodName());
    IEnumerator startTimer()
    {
        //startScript = true;
        yield return new WaitForSeconds(timer);
        readyState = true;
    }
}
