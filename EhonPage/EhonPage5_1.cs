using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EhonPage5_1 : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;


    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
    }


    public void Page5_1()
    {
        ItemChange.Page = 8;
        ItemChange.CalledOnce01 = false;
    }
}
