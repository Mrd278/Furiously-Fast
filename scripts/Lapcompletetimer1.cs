using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lapcompletetimer1 : MonoBehaviour {
    public GameObject Lapcompletetrig;
    public GameObject Halflaptrig;
    public GameObject Minutedisplay;
    public GameObject Seconddisplay;
    public GameObject Millidisplay;
    public GameObject Laptimebox;
    public GameObject Lapcounter;
    public int Lapdone;
    public GameObject Racefinish;

    void Update()
    {
        if (Lapdone == 2)
        {
            Racefinish.SetActive(true);
        }
    }
    void OnTriggerEnter()
    {
        Lapdone += 1;
        { 
        if (Laptimemanager.Secondcount <= 9)
        {
            Seconddisplay.GetComponent<Text>().text = "0" + Laptimemanager.Secondcount + ".";
        }
        else
        {
            Seconddisplay.GetComponent<Text>().text = "" + Laptimemanager.Secondcount + ".";
        }
        if (Laptimemanager.Minutecount <= 9)
        {
            Minutedisplay.GetComponent<Text>().text = "0" + Laptimemanager.Minutecount + ":";
        }
        else
        {
            Minutedisplay.GetComponent<Text>().text = "" + Laptimemanager.Minutecount + ":";
        }
        Millidisplay.GetComponent<Text>().text = "" + Laptimemanager.Millicount;
        }
        PlayerPrefs.SetInt("Minsave", Laptimemanager.Minutecount);
        PlayerPrefs.SetInt("Secsave", Laptimemanager.Secondcount);
        PlayerPrefs.SetFloat("Millisave", Laptimemanager.Millicount);

        Laptimemanager.Minutecount = 0;
        Laptimemanager.Secondcount = 0;
        Laptimemanager.Millicount = 0;
        Lapcounter.GetComponent<Text>().text =""+ Lapdone;
        
        Halflaptrig.SetActive(true);
        Lapcompletetrig.SetActive(false);
    }
}
