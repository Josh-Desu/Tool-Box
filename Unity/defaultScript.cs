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
//using System; //Allows us to use Array.ETC
//using UnityEngine.Audio; //Libraries Assets for Unity Audio System
//using UnityEngine.UI; //Libraries Assets for Unity UI
//using UnityEngine.SceneManagement; //Libraries Assets for Unity Scene Transition/Management
//using UnityEngine.Video; //Libraries Assets for Unity Video Component

public class SCRIPTNAMEGOESHERE : MonoBehaviour
{
    //================================
    #region Variables:
    //[Header("Variables:")]
    //[Space]
    
    //[Space]
    #endregion

    //================================

    #region Unity Methods:

    private void Awake()
    {
        
    }
    
    private void Start()
    {
        //DeclaredVariable = GameObject.Find("gameObjectName").GetComponent<ComponentName>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {

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

    //[Space]
    #endregion

    //================================

    #region Collision Check:
    /*
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        Do Something();
    }
    */

    //[Space]
    #endregion

    //================================

    #region RNG Systems:
    /*
    //StartCoroutine(MethodName());
    IEnumerator MethodName()
    {
        yield return new WaitForSeconds(#f);
    }
    */

    //[Space]
    #endregion
    //================================
}

/*
NOTES:
[RequireComponent(typeof(ComponentName))]
Script requires specific component if needed
Player & Inventory script, attach both script to work or it 
will auto add required script/component if needed
[HideInInspector]
Hides the specific attributes if needed
[Tooltip("This is a definintion")]
Helps define what certain attributes do when you hover your mouse over the attributes title
[Range(0, 20)]
Adds a slider and type option for setting attributes for your Inspector
[DisallowedMultipleComponents]
//Prevents duplicates of same scripts/asses
[Multiline]
Multiple Lines to allow a better view of your paragraph inspector sentences
[System.Serializable]
Shows anything below declared header on Unity Inspector Menu
Also, if you have a class that isn't a Mono-behavior. Having this above the class will show the member of the class
Use an array to have multiple or list to have multiple and add ons with class members showcasing for each attributes
Use dot OP to access 
*/