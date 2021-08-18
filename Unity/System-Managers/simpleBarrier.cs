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

public class barrier : MonoBehaviour
{
    private int health = 0;
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
        {
            Destroy(this.gameObject);
            return;
        }

        GetComponent<SpriteRenderer>().sprite = sprites[health];
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        health++;
    }
}