using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laptimemanager : MonoBehaviour {

    public static int Minutecount;
    public static int Secondcount;
    public static float Millicount;
    public static string Millidisplay;

    public GameObject Minutebox;
    public GameObject Secondbox;
    public GameObject Millibox;

	void Update () {
        Millicount += Time.deltaTime * 10;
        Millidisplay = Millicount.ToString("f0");
        Millibox.GetComponent<Text>().text = "" + Millidisplay;

        if (Millicount >= 10)
        {
            Millicount = 0;
            Secondcount += 1;
        }

        if (Secondcount <= 9)
        {
            Secondbox.GetComponent<Text>().text = "0" + Secondcount + ".";
        }
        else
        {
            Secondbox.GetComponent<Text>().text = "" + Secondcount + ".";
        }
        if (Secondcount >= 60)
        {
            Secondcount = 0;
            Minutecount += 1;
        }
        if (Minutecount <= 9)
        {
            Minutebox.GetComponent<Text>().text = "0" + Minutecount + ":";
        }
        else
        {
            Minutebox.GetComponent<Text>().text = "" + Minutecount + ":";
        }
	}
}
