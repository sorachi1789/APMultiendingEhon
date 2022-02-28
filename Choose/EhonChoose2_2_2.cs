using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EhonChoose2_2_2 : MonoBehaviour
{
    private TextMeshProUGUI EhonText2_2_2_name;
    public GameObject EhonText2_2_2object_name;
    public GameObject EhonChoice2_2;
    EhonChoose2_2 TextCange;
    MainARCam ItemChange;
    GameObject cubes;

    // Start is called before the first frame update
    void Start()
    {
        EhonText2_2_2_name = EhonText2_2_2object_name.GetComponent<TextMeshProUGUI>();
        TextCange = EhonChoice2_2.GetComponent<EhonChoose2_2>();
        ItemChange = GameObject.Find("ARCamera").GetComponent<MainARCam>();

        cubes = GameObject.FindGameObjectWithTag("Choose");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextCange.Choose2_2 == 0)
        {
            EhonText2_2_2_name.text = "銀のオノ";
        }
        if (TextCange.Choose2_2 == 1)
        {
            EhonText2_2_2_name.text = "わかりません";
        }
    }

    public void ClickText2_2_2()
    {
        ItemChange.Ending();
        GameObject[] Charaseirei = GameObject.FindGameObjectsWithTag("Seirei");
        foreach (GameObject Chara in Charaseirei)
        {
            Destroy(Chara);
        }
        Destroy(cubes);
    }
}
