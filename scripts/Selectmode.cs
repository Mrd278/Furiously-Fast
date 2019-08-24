using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectmode : MonoBehaviour {
    public static int Racemode;
    public GameObject Trackselect;
    
	public void Scoremode () {
        Racemode = 1;
        Trackselect.SetActive(true);
	}
	
	public void Timemode () {
        Racemode = 2;
        Trackselect.SetActive(true);
    }
    public void racemode()
    {
        Racemode = 0;
        Trackselect.SetActive(true);
    }
}
