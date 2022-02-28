using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mizukiri : MonoBehaviour
{
    public GameObject MainCam;
    MainARCam ItemChange;
    WoodRd RD;

    // Start is called before the first frame update
    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            RD = GameObject.Find("Rock5 throw Variant(Clone)").GetComponent<WoodRd>();
            RD.rd.useGravity = true;
            ItemChange.Page2_1Count();
        }
    }
}
