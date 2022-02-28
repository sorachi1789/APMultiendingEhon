using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EhonChoose2_2 : MonoBehaviour
{
    private TextMeshProUGUI EhonText2_2_name;
    public GameObject EhonText2_2object_name;
    public int Choose2_2 = 0;
    MainARCam ItemChange;
    GameObject cubes;

    // Start is called before the first frame update
    void Start()
    {
        EhonText2_2_name = EhonText2_2object_name.GetComponent<TextMeshProUGUI>();
        ItemChange = GameObject.Find("ARCamera").GetComponent<MainARCam>();

        cubes = GameObject.FindGameObjectWithTag("Choose");
    }

    void Update()
    {
        if (Choose2_2 == 0)
        {
            EhonText2_2_name.text = "金のオノ";
        }
        if (Choose2_2 == 1)
        {
            EhonText2_2_name.text = "違います！";
        }
    }

    public void ClickText2_2()
    {
        ItemChange.Ending();
        Destroy(cubes);
        GameObject[] Charaseirei = GameObject.FindGameObjectsWithTag("Seirei");
        foreach (GameObject Chara in Charaseirei)
        {
            Destroy(Chara);
        }
    }
}
