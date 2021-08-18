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
using UnityEngine.UI;

public class score : MonoBehaviour
{
   public int scores = 0;
   public void UpdateScore()
   {
       GetComponent<Text>().text = "Score: " + scores;
   }

}