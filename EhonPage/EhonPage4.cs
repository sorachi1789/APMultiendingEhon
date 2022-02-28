using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EhonPage4 : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;

    ScriptChange story;
    public GameObject textCanage;

    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
        story = textCanage.GetComponent<ScriptChange>();
    }


    public void Page4()
    {
        ItemChange.Pare = 2;
        ItemChange.Page = 7;
        ItemChange.Page2_1 = 0;
    }
}
