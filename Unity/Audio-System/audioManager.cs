/*
* Copyright (C) Josh Y. - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited 
* Proprietary and confidential
* Written by Josh Y. <joyang112@gmail.com>, June 2017
*
* Instructions:
* Go into specific script that will play the audio source and use line...
* FindObjectOfType<AudioManager>().Play("PlayerDeath");
* AudioManager References this script while playerdeath references the audio clip created
*/

//Libraries:
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //Allows us to use Array.ETC
using UnityEngine.Audio; //Libraries Assets for Unity Audio System

public class audioManager : MonoBehaviour
{
    #region Variables:
    [Header("Audio Manager")]
    //Set public and the Array name of the AUDIO SCRIPT so if script is named hi, use hi[]
    public sound01[] sounds;
    //With duplication check of AudioManager explained below...
    public static audioManager instance;
    #endregion

    //================================

    #region Unity Methods:
    private void Awake()
    {
        //Checks if theres a duplicate of AudioManager before starting another
        if(instance == null)
        {
            instance = this;
        }
        else{
            Destroy(gameObject);
            return;
        }
        //Won't destroy when loading into next scene
        DontDestroyOnLoad(gameObject);

        //Setup for Audio Sources
        foreach(sound01 s in sounds)
        {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
        }
    }
    private void Start()
    {
        //Play("Theme"); //Play Main theme song on start
    }
    #endregion

    //================================

    #region Methods:
    //Plays specific audio source from sound01 script
    public void Play(string name)
    {
        sound01 s = Array.Find(sounds, sounds => sounds.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
    #endregion
}