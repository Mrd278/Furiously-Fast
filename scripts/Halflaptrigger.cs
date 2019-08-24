using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halflaptrigger : MonoBehaviour
{
    public GameObject Lapcompletetrig;
    public GameObject Halflaptrig;

    void OnTriggerEnter()
    {
        Lapcompletetrig.SetActive(true);
        Halflaptrig.SetActive(false);
    } 
}
