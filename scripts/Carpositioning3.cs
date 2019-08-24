using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carpositioning3 : MonoBehaviour
{
    public GameObject positiondisplay;
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "carpos")
        {
            positiondisplay.GetComponent<Text>().text = "4th PLACE";
        }

    }
}