using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour {
    public int cashvalue;
    public static int totalcash;
    public GameObject cashdisplay;
	
	void Update () {
        cashvalue = totalcash;
        cashdisplay.GetComponent<Text>().text = "Rs  " + cashvalue;
	}
}
