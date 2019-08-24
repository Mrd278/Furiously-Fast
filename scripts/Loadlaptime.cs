using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loadlaptime : MonoBehaviour {

    public int Mincount;
    public int Seccount;
    public float Millicount;
    public GameObject Mindisplay;
    public GameObject Secdisplay;
    public GameObject Millidisplay;
	void Start () {
        Mincount = PlayerPrefs.GetInt("Minsave");
        Mincount = PlayerPrefs.GetInt("Secsave");
        Mincount = PlayerPrefs.GetInt("Millisave");

        Mindisplay.GetComponent<Text>().text = "" + Mincount +":";
        Secdisplay.GetComponent<Text>().text = "" + Seccount + ".";
        Millidisplay.GetComponent<Text>().text = "" + Millicount;
		
	}
	
}
