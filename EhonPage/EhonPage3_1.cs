using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EhonPage3_1 : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;


    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
    }


    public void Page3_1()
    {
        ItemChange.Page = 5;
    }
}
