using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class carenter : MonoBehaviour {

    public GameObject Mycar;
    public GameObject Man;
    void OnTriggerEnter(Collider other)
    {
        
    
        if (other.tag=="man" && Input.GetKeyDown(KeyCode.Escape))
        {
            Mycar.GetComponent<CarController>().enabled = true;
            Man.SetActive(false);
        }

    }
}
