using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetImage : MonoBehaviour
{

    private Image m_Image;
    public Sprite[] m_Sprite;
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
        if (ItemChange.Item == 0)
        {
            m_Image.sprite = m_Sprite[0];
        }
        if (ItemChange.Item == 1)
        {
            m_Image.sprite = m_Sprite[1];
        }
        if (ItemChange.Item == 2)
        {
            m_Image.sprite = m_Sprite[2];
        }
        if (ItemChange.Item == 3)
        {
            m_Image.sprite = m_Sprite[3];
        }
        if (ItemChange.Item == 4)
        {
            m_Image.sprite = m_Sprite[4];
        }
        if (ItemChange.Item == 5)
        {
            m_Image.sprite = m_Sprite[5];
        }
        if (ItemChange.Item == 6)
        {
            m_Image.sprite = m_Sprite[6];
        }
    }
}
