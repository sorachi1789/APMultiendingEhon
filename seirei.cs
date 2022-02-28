using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class seirei : MonoBehaviour
{
    
    public GameObject characterAxe;//生成するもの
    public GameObject characterApple;//生成するもの
    public GameObject characterGoose;//生成するもの
    
    GameObject character;
    GameObject camchara;
    [SerializeField]
    GameObject AlphaBrack;
    [SerializeField]
    Transform Cam;//親
    [SerializeField]
    Transform characterParent;//親
    public GameObject Kappa;

    public int Count = 0;
    public GameObject SeireiAlive_water;
    seireiAlive Insta;
    public GameObject MainCam;
    MainARCam ItemChange;
    WoodRd RD;

    public int SpCount()
    {
        return Count;
    }


    // Start is called before the first frame update
    void Start()
    {
        Insta = SeireiAlive_water.GetComponent<seireiAlive>();
        ItemChange = MainCam.GetComponent<MainARCam>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Axe"))
        {
            Count=1;
            Debug.Log("now" + Count);
        }
        if (other.CompareTag("Apple"))
        {
            Count=2;
            Debug.Log("now" + Count);
        }
        if (other.CompareTag("Goose"))
        {
            Count=3;
            Debug.Log("now" + Count);
        }
       
    }
    void OnTriggerExit(Collider other)
    {
        //離れたオブジェクトのタグが"Player"のとき
        if (other.CompareTag("Axe"))
        {
            Destroy(other.gameObject);
            character = Instantiate(characterAxe, characterParent);
            Insta.Axeinsta();
            ItemChange.Page2_1Count();
            //camchara = Instantiate(AlphaBrack,Cam);

        }
        if (other.CompareTag("Apple"))
        {
            Destroy(other.gameObject);
            character = Instantiate(characterApple, characterParent);
            Insta.Appleinsta();
            ItemChange.Page2_1Count();
            //camchara = Instantiate(AlphaBrack,Cam);


        }
        if (other.CompareTag("Goose"))
        {
            Destroy(other.gameObject);
                character = Instantiate(characterGoose, characterParent);
            Insta.Gooseinsta();
            ItemChange.Page2_1Count();
            //camchara = Instantiate(AlphaBrack,Cam);
        }
        if (other.CompareTag("Wood"))
        {
            RD = GameObject.Find("wood-3D throw(Clone)").GetComponent<WoodRd>();
            RD.rd.useGravity = true;
            //Destroy(other.gameObject);
            ItemChange.Page2_1Count();
            //character = Instantiate(WoodVariant, WoodPare);
        }
        if (other.CompareTag("Cucumber"))
        {
            Destroy(other.gameObject);
            character = Instantiate(Kappa, characterParent);
            ItemChange.Page2_1Count();
        }
        
    }

}
