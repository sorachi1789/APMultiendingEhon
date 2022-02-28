using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EhonChoose5_2_2 : MonoBehaviour
{
    private TextMeshProUGUI EhonText5_2_2_name;
    public GameObject EhonText5_2_2object_name;
    public GameObject EhonChoice5_2;
    EhonChoose5_2 TextCange;
    ScriptChange story;
    GameObject cubes;
    MainARCam ItemChange;

    // Start is called before the first frame update
    void Start()
    {
        EhonText5_2_2_name = EhonText5_2_2object_name.GetComponent<TextMeshProUGUI>();
        TextCange = EhonChoice5_2.GetComponent<EhonChoose5_2>();
        story = GameObject.Find("EhonText5-2").GetComponent<ScriptChange>();
        ItemChange = GameObject.Find("ARCamera").GetComponent<MainARCam>();

        cubes = GameObject.FindGameObjectWithTag("Choose");

    }

    // Update is called once per frame
    void Update()
    {
        if (TextCange.Choose5_2 == 0)
        {
            EhonText5_2_2_name.text = "銀の"+ ItemChange.Throw;
        }
        if (TextCange.Choose5_2 == 1)
        {
            EhonText5_2_2_name.text = "わかりません";
        }
    }

    public void ClickText5_2_2()
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
