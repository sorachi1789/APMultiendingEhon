using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EhonChoose2_2_3 : MonoBehaviour
{
    private TextMeshProUGUI EhonText2_2_3_name;
    public GameObject EhonText2_2_3object_name;
    public GameObject EhonChoice2_2;
    EhonChoose2_2 TextCange;
    MainARCam ItemChange;
    int C = 0;
    GameObject cubes;

    // Start is called before the first frame update
    void Start()
    {
        EhonText2_2_3_name = EhonText2_2_3object_name.GetComponent<TextMeshProUGUI>();
        TextCange = EhonChoice2_2.GetComponent<EhonChoose2_2>();
        ItemChange = GameObject.Find("ARCamera").GetComponent<MainARCam>();

        cubes = GameObject.FindGameObjectWithTag("Choose");
    }

    // Update is called once per frame
    void Update()
    {
        if (TextCange.Choose2_2 == 0)
        {
            EhonText2_2_3_name.text = "どっちでも\nないです";
        }
        if (TextCange.Choose2_2 == 1)
        {
            EhonText2_2_3_name.text = "そうです！";
        }
        if (C == 2)
        {
            Destroy(cubes);
        }
        
    }

    public void ClickText2_2_3()
    {
        TextCange.Choose2_2++;
        ItemChange.Page2_2Count();
        C++;
    }
}
