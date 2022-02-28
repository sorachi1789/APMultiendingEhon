using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EhonPage6 : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;


    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
    }


    public void Page6()
    {
        ItemChange.Page = 10;
    }
}
