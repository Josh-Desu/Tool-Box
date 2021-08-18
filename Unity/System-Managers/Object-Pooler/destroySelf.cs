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

public class destroySelf : MonoBehaviour
{
    [Header("Destruction Settings:")]
    public bool ManualControl = false;
    public float destructTimer = 1.0f;
    private bool calledTimer = false;
    private void Update()
    {
        if(ManualControl == true && calledTimer == true)
        {
            delayDestruct(destructTimer);
        }
    }

    //Destroy gameobject in scene to keep low load
    public void Destruct()
    {
        Destroy(gameObject);
    }

    public void delayDestruct(float a)
    {
        Destroy(gameObject, a);
    }

    //Destruct components 
    private void DestructC()
    {
        Destroy(gameObject);
    }
    private void delayDestructC(float a)
    {
        Destroy(gameObject, a);
    }
}
