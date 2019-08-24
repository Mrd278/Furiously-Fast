using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carpositioning1 : MonoBehaviour {
    public GameObject positiondisplay;
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "carpos")
        {
            positiondisplay.GetComponent<Text>().text = "2nd PLACE";
        }

    }
}
