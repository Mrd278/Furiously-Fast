using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentCar1 : MonoBehaviour {
    public GameObject Themarker;
    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;
    public GameObject mark4;
    public GameObject mark5;
    public GameObject mark6;
    public GameObject mark7;
    public GameObject mark8;
    public GameObject mark9;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public GameObject mark17;
    public GameObject mark18;
    public GameObject mark19;
    public GameObject mark20;
    public GameObject mark21;
    public GameObject mark22;
    public GameObject mark23;


    public int Marktracker;

    void Update()
    {
       if (Marktracker==0)
        {
            Themarker.transform.position = mark1.transform.position;
        }
        if (Marktracker == 1)
        {
            Themarker.transform.position = mark2.transform.position;
        }
        if (Marktracker == 2)
        {
            Themarker.transform.position = mark3.transform.position;
        }
        if (Marktracker == 3)
        {
            Themarker.transform.position = mark4.transform.position;
        }
        if (Marktracker == 4)
        {
            Themarker.transform.position = mark5.transform.position;
        }
        if (Marktracker == 5)
        {
            Themarker.transform.position = mark6.transform.position;
        }
        if (Marktracker == 6)
        {
            Themarker.transform.position = mark7.transform.position;
        }
        if (Marktracker == 7)
        {
            Themarker.transform.position = mark8.transform.position;
        }
        if (Marktracker == 8)
        {
            Themarker.transform.position = mark9.transform.position;
        }
        if (Marktracker == 9)
        {
            Themarker.transform.position = mark10.transform.position;
        }
        if (Marktracker == 10)
        {
            Themarker.transform.position = mark11.transform.position;
        }
        if (Marktracker == 11)
        {
            Themarker.transform.position = mark12.transform.position;
        }
        if (Marktracker == 12)
        {
            Themarker.transform.position = mark13.transform.position;
        }
        if (Marktracker == 13)
        {
            Themarker.transform.position = mark14.transform.position;
        }
        if (Marktracker == 14)
        {
            Themarker.transform.position = mark15.transform.position;
        }
        if (Marktracker == 15)
        {
            Themarker.transform.position = mark16.transform.position;
        }
        if (Marktracker == 16)
        {
            Themarker.transform.position = mark17.transform.position;
        }
        if (Marktracker == 17)
        {
            Themarker.transform.position = mark18.transform.position;
        }
         if (Marktracker == 18)
        {
            Themarker.transform.position = mark19.transform.position;
        }
        if (Marktracker == 19)
        {
            Themarker.transform.position = mark20.transform.position;
        }
        if (Marktracker == 20)
        {
            Themarker.transform.position = mark21.transform.position;
        }
        if (Marktracker == 21)
        {
            Themarker.transform.position = mark22.transform.position;
        }
        if (Marktracker == 22)
        {
            Themarker.transform.position = mark23.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider Collision)
    {
        if (Collision.gameObject.tag == "opponent01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Marktracker += 1;
            if (Marktracker == 22)
            {
                Marktracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }


}
