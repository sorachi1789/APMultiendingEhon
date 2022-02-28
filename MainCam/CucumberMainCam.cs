using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CucumberMainCam : MonoBehaviour
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

    public void ClickCucumber()
    {
        Debug.Log("タッチされたにゃー");
        ItemChange.CucumberChange();
        ItemChange.Page4Count();
    }
}
