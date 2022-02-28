using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PageSet : MonoBehaviour
{
    private TextMeshProUGUI pagebox_name;
    public GameObject pageobject_name;
    public GameObject MainCam;
    MainARCam ItemChange;
    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
        pagebox_name = pageobject_name.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemChange.Page == 1)
        {
            //1page
            pagebox_name.text = "Page1-1";
        }
        if (ItemChange.Page == 2)
        {
            //1page
            pagebox_name.text = "Page1-2";
        }
        if (ItemChange.Page == 3)
        {
            //1page
            pagebox_name.text = "Page2-1";
        }
        if (ItemChange.Page == 4)
        {
            //1page
            pagebox_name.text = "Page2-2";
        }
        if (ItemChange.Page == 5)
        {
            //1page
            pagebox_name.text = "Page3-1";
        }
        if (ItemChange.Page == 6)
        {
            //1page
            pagebox_name.text = "Page3-2";
        }
        if (ItemChange.Page == 7)
        {
            //1page
            pagebox_name.text = "Page4";
        }
        if (ItemChange.Page == 8)
        {
            //1page
            pagebox_name.text = "Page5-1";
        }
        if (ItemChange.Page == 9)
        {
            //1page
            pagebox_name.text = "Page5-2";
        }
        if (ItemChange.Page == 10)
        {
            //1page
            pagebox_name.text = "Page6";
        }
    }
}
