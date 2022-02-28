using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackImage : MonoBehaviour
{
    private Image m_Image;
    public Sprite[] Back;
    MainARCam ItemChange;
    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
        ItemChange = GameObject.Find("ARCamera").GetComponent<MainARCam>();

    }

    // Update is called once per frame
    void Update()
    {

        if (ItemChange.Page == 2)
        {
            //no
            if (ItemChange.Gamen1_2 == 0)
            {
                m_Image.sprite = Back[0];
            }
            //yes
            if (ItemChange.Gamen1_2 == 1)
            {
                m_Image.sprite = Back[1];
            }
        }
        if (ItemChange.Page == 3 || ItemChange.Page == 4)
        {
            //no seirei
            if (ItemChange.Gamen2_1 == 0)
            {
                m_Image.sprite = Back[2];
            }
            //seirei
            if (ItemChange.Gamen2_1 == 1)
            {
                m_Image.sprite = Back[3];
            }
        }
        if (ItemChange.Page == 5)
        {
            //no
            if (ItemChange.Gamen3_1 == 0)
            {
                m_Image.sprite = Back[4];
            }
            //yes
            if (ItemChange.Gamen3_1 == 1)
            {
                m_Image.sprite = Back[5];
            }
        }
        if (ItemChange.Page == 6)
        {
            //no
            if (ItemChange.Gamen3_2 == 0)
            {
                m_Image.sprite = Back[4];
            }
            //yes
            if (ItemChange.Gamen3_2 == 1)
            {
                m_Image.sprite = Back[6];
            }
        }
        if (ItemChange.Page == 8)
        {
            //no
            if (ItemChange.Gamen5_1 == 0)
            {
                m_Image.sprite = Back[7];
            }
            //yes
            if (ItemChange.Gamen5_1 == 1)
            {
                if (ItemChange.Throw == "オノ")
                {
                    m_Image.sprite = Back[8];
                }
                if (ItemChange.Throw == "リンゴ")
                {
                    m_Image.sprite = Back[9];
                }
                if (ItemChange.Throw == "ガチョウ")
                {
                    m_Image.sprite = Back[10];
                }
            }
            if (ItemChange.Gamen5_1 == 2)
            {
                //河童
                m_Image.sprite = Back[11];
            }
            if (ItemChange.Gamen5_1 == 3)
            {
                //木
                m_Image.sprite = Back[15];
            }
            if (ItemChange.Gamen5_1 == 4)
            {
                //石
                m_Image.sprite = Back[16];
            }
        }
        if (ItemChange.Page == 9)
        {
            //no
            if (ItemChange.Gamen5_2 == 0)
            {
                m_Image.sprite = Back[7];
            }
            //yes
            if (ItemChange.Gamen5_2 == 1)
            {
                if (ItemChange.Throw == "オノ")
                {
                    m_Image.sprite = Back[8];
                }
                if (ItemChange.Throw == "リンゴ")
                {
                    m_Image.sprite = Back[9];
                }
                if (ItemChange.Throw == "ガチョウ")
                {
                    m_Image.sprite = Back[10];
                }
            }
        }
        if (ItemChange.Page == 10)
        {
            if (ItemChange.Gamen6 == 0)
            {
                //saisyo
                m_Image.sprite = Back[12];
            }
            if (ItemChange.Gamen6 == 1)
            {
                //saisyo
                m_Image.sprite = Back[12];
            }
            if (ItemChange.Gamen6 == 2)
            {
                //Axe get
                m_Image.sprite = Back[13];
            }
            if (ItemChange.Gamen6 == 3)
            {
                //Apple get
                m_Image.sprite = Back[14];
            }
            if (ItemChange.Gamen6 == 4)
            {
                //Apple get
                m_Image.sprite = Back[17];
            }
        }
    }
}
