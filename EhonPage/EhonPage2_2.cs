using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EhonPage2_2 : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;

    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
    }


    public void Page2_2()
    {
        ItemChange.Page = 4;
        Debug.Log("認識"+ItemChange.Page );
    }
}
