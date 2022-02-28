using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EhonChoose5_2 : MonoBehaviour
{
    private TextMeshProUGUI EhonText5_2_name;
    public GameObject EhonText5_2object_name;
    public int Choose5_2 = 0;
    GameObject cubes;
    MainARCam ItemChange;

    // Start is called before the first frame update
    void Start()
    {
        EhonText5_2_name = EhonText5_2object_name.GetComponent<TextMeshProUGUI>();
        ItemChange = GameObject.Find("ARCamera").GetComponent<MainARCam>();

        cubes = GameObject.FindGameObjectWithTag("Choose");
    }

    void Update()
    {
        if (Choose5_2 == 0)
        {
            EhonText5_2_name.text = "金の" + ItemChange.Throw;
        }
        if (Choose5_2 == 1)
        {
            EhonText5_2_name.text = "違います！";
        }
    }

    public void ClickText5_2()
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
