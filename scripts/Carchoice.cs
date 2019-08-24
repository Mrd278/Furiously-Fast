using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carchoice : MonoBehaviour {
    public GameObject Redbody;
    public GameObject Bluebody;
    public GameObject Greenbody;
    public int CarImport;
	void Start () {
        CarImport = Globalcar.Cartype;
        if (CarImport == 1)
        {
            Redbody.SetActive(true);
        }
        CarImport = Globalcar.Cartype;
        if (CarImport == 2)
        {
            Bluebody.SetActive(true);
        }
        CarImport = Globalcar.Cartype;
        if (CarImport == 3)
        {
            Greenbody.SetActive(true);
        }
    }

}
