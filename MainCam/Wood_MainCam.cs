﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood_MainCam : MonoBehaviour
{
    MainARCam ItemChange;
    public GameObject textChange;

    // Start is called before the first frame update
    void Start()
    {
        ItemChange = GameObject.Find("ARCamera").GetComponent<MainARCam>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickWood()
    {
        Debug.Log("タッチされたにゃー");
        ItemChange.WoodChange();
        ItemChange.Page4Count();
    }
}
