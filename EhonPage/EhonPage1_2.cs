﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EhonPage1_2 : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;


    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
    }


    public void Page1_2()
    {
        ItemChange.Page = 2;
    }
}
