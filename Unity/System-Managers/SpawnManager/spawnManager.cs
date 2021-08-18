/*
* Copyright (C) Josh Y. - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited 
* Proprietary and confidential
* Written by Josh Y. <joyang112@gmail.com>, June 2017
*/
//Libraries:
//================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSystem : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] spawnPoints;

    private int rand;
    private int randPosition;

    public float startTimeBtwSpawns;
    private float timeBtwSpawns;

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    private void Update()
    {
        if(timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, enemies.Length);
            randPosition = Random.Range(0, spawnPoints.Length);
            Instantiate(enemies[rand], spawnPoints[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

}