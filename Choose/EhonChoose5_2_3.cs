using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EhonChoose5_2_3 : MonoBehaviour
{
    private TextMeshProUGUI EhonText5_2_3_name;
    public GameObject EhonText5_2_3object_name;
    public GameObject EhonChoice5_2;
    EhonChoose5_2 TextCange;
    MainARCam ItemChange;
    int C = 0;
    GameObject cubes;

    // Start is called before the first frame update
    void Start()
    {
        EhonText5_2_3_name = EhonText5_2_3object_name.GetComponent<TextMeshProUGUI>();
        TextCange = EhonChoice5_2.GetComponent<EhonChoose5_2>();
        ItemChange = GameObject.Find("ARCamera").GetComponent<MainARCam>();

        cubes = GameObject.FindGameObjectWithTag("Choose");
    }

    // Update is called once per frame
    void Update()
    {
        if (TextCange.Choose5_2 == 0)
        {
            EhonText5_2_3_name.text = "どっちでも\nないです";
        }
        if (TextCange.Choose5_2 == 1)
        {
            EhonText5_2_3_name.text = "そうです！";
        }
        if (C == 2)
        {
            Destroy(cubes);
        }

    }

    public void ClickText5_2_3()
    {
        TextCange.Choose5_2++;
        ItemChange.Page5_2Count();
        C++;
    }
}
