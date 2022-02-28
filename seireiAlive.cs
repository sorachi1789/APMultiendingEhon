using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seireiAlive : MonoBehaviour
{
    public GameObject Seireipack;
    seirei Alive;
    public GameObject characterAxe;//生成するもの
    public GameObject characterApple;//生成するもの
    public GameObject characterGoose;//生成するもの
    GameObject character;
    
    public Transform characterParent;//親
    public GameObject Choose;//生成するもの
    GameObject WitchChoose;

    public Transform TextParent;//親
    // Start is called before the first frame update
    void Start()
    {
        Alive=Seireipack.GetComponent<seirei>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Appleinsta()
    {
        character = Instantiate(characterApple, characterParent);
        WitchChoose = Instantiate(Choose, TextParent);

    }
    public void Axeinsta()
    {
        character = Instantiate(characterAxe, characterParent);
        WitchChoose = Instantiate(Choose, TextParent);
    }
    public void Gooseinsta()
    {
        character = Instantiate(characterGoose, characterParent);
        WitchChoose = Instantiate(Choose, TextParent);
    }

}
