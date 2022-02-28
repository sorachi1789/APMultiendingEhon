using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EhonPage1_1 : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;


    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
    }


    public void Page1_1()
    {
        ItemChange.Page = 1;
    }
}
