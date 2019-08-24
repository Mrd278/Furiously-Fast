using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carpositioning : MonoBehaviour {
    public GameObject positiondisplay;
    public static int pos=1;
    public static int c = 0;
    public string position;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "carpos")
        {
            c = c - 1;
            int total = c + pos;
            position = total.ToString();
            positiondisplay.GetComponent<Text>().text = "POSITION: " + position;
        }

    }
}
