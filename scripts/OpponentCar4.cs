using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentCar4 : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject Mark1;
    public GameObject Mark2;
    public GameObject Mark3;
    public GameObject Mark4;
    public GameObject Mark5;
    public GameObject Mark6;
    public GameObject Mark7;
    public GameObject Mark8;
    public GameObject Mark9;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public GameObject Mark21;
    public GameObject Mark22;
    public GameObject Mark23;


    public int MarkTracker;

    void Update()
    {
        if (MarkTracker == 0)
        {
            TheMarker.transform.position = Mark1.transform.position;
        }
        if (MarkTracker == 1)
        {
            TheMarker.transform.position = Mark2.transform.position;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = Mark3.transform.position;
        }
        if (MarkTracker == 3)
        {
            TheMarker.transform.position = Mark4.transform.position;
        }
        if (MarkTracker == 4)
        {
            TheMarker.transform.position = Mark5.transform.position;
        }
        if (MarkTracker == 5)
        {
            TheMarker.transform.position = Mark6.transform.position;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = Mark7.transform.position;
        }
        if (MarkTracker == 7)
        {
            TheMarker.transform.position = Mark8.transform.position;
        }
        if (MarkTracker == 8)
        {
            TheMarker.transform.position = Mark9.transform.position;
        }
        if (MarkTracker == 9)
        {
            TheMarker.transform.position = Mark10.transform.position;
        }
        if (MarkTracker == 10)
        {
            TheMarker.transform.position = Mark11.transform.position;
        }
        if (MarkTracker == 11)
        {
            TheMarker.transform.position = Mark12.transform.position;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = Mark13.transform.position;
        }
        if (MarkTracker == 13)
        {
            TheMarker.transform.position = Mark14.transform.position;
        }
        if (MarkTracker == 14)
        {
            TheMarker.transform.position = Mark15.transform.position;
        }
        if (MarkTracker == 15)
        {
            TheMarker.transform.position = Mark16.transform.position;
        }
        if (MarkTracker == 16)
        {
            TheMarker.transform.position = Mark17.transform.position;
        }
        if (MarkTracker == 17)
        {
            TheMarker.transform.position = Mark18.transform.position;
        }
        if (MarkTracker == 18)
        {
            TheMarker.transform.position = Mark19.transform.position;
        }
        if (MarkTracker == 19)
        {
            TheMarker.transform.position = Mark20.transform.position;
        }
        if (MarkTracker == 20)
        {
            TheMarker.transform.position = Mark21.transform.position;
        }
        if (MarkTracker == 21)
        {
            TheMarker.transform.position = Mark22.transform.position;
        }
        if (MarkTracker == 22)
        {
            TheMarker.transform.position = Mark23.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider Collision)
    {
        if (Collision.gameObject.tag == "opponent4")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 22)
            {
                TheMarker.transform.position = Mark23.transform.position;
                MarkTracker = 23;
            }
            if (MarkTracker==23)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }


}
