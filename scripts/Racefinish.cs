using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class Racefinish : MonoBehaviour {

    public GameObject Mycar;
    public GameObject Finishcam;
    public GameObject Viewmode;
    public GameObject Levelmusic;
    public GameObject Laptimemanager;
    public AudioSource raceend;

    void OnTriggerEnter()
    {
        if (Timemode.istimemode == true)
        {
            //we are on race time
        }
        else {
            Mycar.SetActive(false);
            Mycar.GetComponent<CarController>().enabled = false;
            Mycar.GetComponent<CarUserControl>().enabled = false;
            Mycar.SetActive(true);
            Finishcam.SetActive(true);
            Levelmusic.SetActive(false);
            Viewmode.SetActive(false);
            Laptimemanager.SetActive(false);
            SceneManager.LoadScene(7);
            raceend.Play();
        }

    }
}
