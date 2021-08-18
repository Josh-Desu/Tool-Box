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

public class AttackSystem : MonoBehaviour
{
    private SupManager sP;
    private objectPool objectPooler;

    [Header("Test Input, delete when finished setting condition")]
    public bool dropBomb = false;

    [Header("Behavior Settings:")]
    public GameObject ammoPrefab;
    public Transform[] startLaunch;
    public bool scatterDrop = false;
    public int ammo = 5;
    public float dropRate = 0.5f;
    private bool attackReady = true;
    
    private void Awake()
    {
        sP = GetComponent<SupManager>();
    }

    private void Start()
    {
        objectPooler = objectPool.Instance;
    }

    private void Update()
    {
        InitiateAttack();
        checkAmmo();
    }

    private void InitiateAttack()
    {
        if (dropBomb == true && attackReady == true && ammo > 0 && scatterDrop == true)
        {
            StartCoroutine(InitiateScatterDrop());

        }
        else if (dropBomb == true && attackReady == true && ammo > 0)
        {
            StartCoroutine(InitiateDrop());
        }
    }
    private void checkAmmo()
    {
        if(ammo == 0)
        {
            sP.isCompleted = true;
        }
    }
    //Drop Rate
    IEnumerator InitiateDrop()
    {
        attackReady = false;
        GameObject Bomb = Instantiate(ammoPrefab, startLaunch[0].transform.position, startLaunch[0].rotation);        
        //objectPooler.SpawnFromPool("Carpet", startLaunch[0].transform.position, startLaunch[0].rotation); ;
        ammo--;
        yield return new WaitForSeconds(dropRate);
        attackReady = true;
    }
    IEnumerator InitiateScatterDrop()
    {

        for(int i = 0; i < startLaunch.Length; i++)
        {
            if(attackReady == true)
            {
                attackReady = false;
                GameObject Bomb = Instantiate(ammoPrefab, startLaunch[i].transform.position, startLaunch[i].rotation);
                //objectPooler.SpawnFromPool("Carpet", startLaunch[i].transform.position, startLaunch[i].rotation); ;
                ammo--;
                yield return new WaitForSeconds(dropRate);
                attackReady = true;

            }
        }
    }
}
