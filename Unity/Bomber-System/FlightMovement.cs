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

public class FlightMovement : MonoBehaviour
{
    private SupManager SpManager;

    [Header("Movement Settings:")]
    public float fAltitude = 45.0f; //Height at which plane should maintain
    public float fSpeed = 15.0f; //Speed of plane
    private Rigidbody rb;

    //For exit flight path
    [Header("Yawn pitch for exit path:")]
    [Space]
    public float rotateSpeed = 1.5f;
    public float _exitRotationX = -17.0f, _exitRotationY = 35.0f,
        _exitRotationZ = -27.0f;

    private GameObject planeObject;
    
    private void Awake()
    {
        //Initiate data
        SpManager = GetComponent<SupManager>();
        rb = GetComponent<Rigidbody>();
        planeObject = gameObject;
    }

    private void Start()
    {
        //Instantiate height of raycast down/up of terrain to set up alt checker

    }

    private void Update()
    {

        //Checks status to start exit route
        if(SpManager.isCompleted == true)
        {
            startExit();
        }
    }
    private void FixedUpdate()
    {
        //Calls movement consistently
        Enroute();
        //CheckAlt(); // Checks altitude and alters height dimension accordingly
    }

    private void Enroute()
    {
        //Movement Behavior
        rb.AddRelativeForce(0, 0, fSpeed);
    }

    // Methods regarding other behaviors
    public void startExit()
    {
        //Rotate for smoother exit transition style
        Quaternion target = Quaternion.Euler(_exitRotationX, _exitRotationY, _exitRotationZ);
        gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotateSpeed);    
    }
}
