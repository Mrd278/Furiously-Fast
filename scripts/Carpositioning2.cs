using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carpositioning2 : MonoBehaviour
{
    public GameObject positiondisplay;
    public static int c = 0;
    public static int pos;
    public string position;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "carpos")
        {
            c = c + 1;
            int total = c + pos;
            position = total.ToString();
            positiondisplay.GetComponent<Text>().text = "POSITION: "+position;
        }

    }
}