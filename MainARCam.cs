using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainARCam : MonoBehaviour
{
    public GameObject parent2_1;
    public GameObject parent5_1;
    GameObject parent;
    public GameObject wood;
    public GameObject Apple;
    public GameObject Goose;
    public GameObject Cucumber;
    public GameObject Axe;
    public GameObject rock;
    public float force = 250;
    public bool CalledOnce01 = false;

    public int Item = 0; //何を投げるのか
    public string Throw = "None";
    public int Page;
    public int Pare = 0;

    public int Page2_1 = 0;
    public int Page2_2 = 0;
    public int Page4 = 0;
    public int Page5_2 = 0;
    public int Page6_2 = 0;
    public int ED = 0;

    public int text5_2=0;

    public int next1_2 = 0;
    public int next2_1 = 0;
    public int next2_2 = 0;
    public int next3_1 = 0;
    public int next3_2 = 0;
    public int next4 = 0;
    public int next5_1 = 0;
    public int next5_2 = 0;

    public int Gamen1_2;
    public int Gamen2_1;
    public int Gamen2_2;
    public int Gamen3_1;
    public int Gamen3_2;
    public int Gamen5_1;
    public int Gamen5_2;
    public int Gamen6;

    void Update()
    {
        if (Pare == 1)
        {
            parent = parent2_1;
        }
        if (Pare == 2)
        {
            parent = parent5_1;
        }
        if(Page == 3 ||  Page == 8)
            {
        }
        if (Input.GetMouseButtonDown(0))
        {

            if (!CalledOnce01 && Item == 1)
            {
                GameObject instanceBall = Instantiate(wood, transform.position, transform.rotation);
                instanceBall.transform.parent = parent.transform;
                instanceBall.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Item = 0;
                
                CalledOnce01 = true;
            }
            if (!CalledOnce01 && Item == 2)
            {
                GameObject instanceBall = Instantiate(Apple, transform.position, transform.rotation);
                instanceBall.transform.parent = parent.transform;
                instanceBall.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Item = 0;
                
                CalledOnce01 = true;
            }
            if (!CalledOnce01 && Item == 3)
            {
                GameObject instanceBall = Instantiate(Goose, transform.position, transform.rotation);
                instanceBall.transform.parent = parent.transform;
                instanceBall.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                
                Item = 0;
                CalledOnce01 = true;
            }
            if (!CalledOnce01 && Item == 4)
            {
                GameObject instanceBall = Instantiate(Cucumber, transform.position, transform.rotation);
                instanceBall.transform.parent = parent.transform;
                instanceBall.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Item = 0;
                
                CalledOnce01 = true;
            }
            if (!CalledOnce01 && Item == 5)
            {
                GameObject instanceBall = Instantiate(Axe, transform.position, transform.rotation);
                instanceBall.transform.parent = parent.transform;
                instanceBall.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Item = 0;
                
                CalledOnce01 = true;
            }
            if (!CalledOnce01 && Item == 6)
            {
                GameObject instanceBall = Instantiate(rock, transform.position, transform.rotation);
                instanceBall.transform.parent = parent.transform;
                instanceBall.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Item = 0;
                
                CalledOnce01 = true;
            }

        }
    }

    public void WoodChange()
    {
        Item = 1;
        Throw = "木";
    }
    public void AppleChange()
    {
        Item = 2;
        Throw = "リンゴ";
    }
    public void GooseChange()
    {
        Item = 3;
        Throw = "ガチョウ";
    }
    public void CucumberChange()
    {
        Item = 4;
        Throw = "キュウリ";
    }
    public void AxeChange()
    {
        Item = 5;
        Throw = "オノ";
    }
    public void RockChange()
    {
        Item = 6;
        Throw = "石";
    }

    public void Page2_1Count()
    {
        Page2_1 = 1;
    }
    public void Page2_2Count()
    {
        Page2_2++;
    }
    public void Page4Count()
    {
        Page4 = 1;
    }

    public void Ending()
    {
        ED=1;
    }
    public void Page5_2Count()
    {
        Page5_2++;
    }
}
