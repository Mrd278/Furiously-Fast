using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globalcar : MonoBehaviour {
    public static int Cartype;
    public GameObject Trackwindow;

    public void Redcar()
    {
        Cartype = 1;
        Trackwindow.SetActive(true);
    }
    public void Bluecar()
    {
        Cartype = 2;
        Trackwindow.SetActive(true);
    }
    public void Greencar()
    {
        Cartype = 3;
        Trackwindow.SetActive(true);
    }
}
