using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EhonPage2_1 : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;
    bool Call = false;
    


    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
    }


    public void Page2_1()
    {

        ItemChange.Page = 3;
        if (!Call)
        {
            ItemChange.AxeChange();
            ItemChange.Pare = 1;
            Call = true;
        }
    }
}
