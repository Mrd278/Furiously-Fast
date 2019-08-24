using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour {

    public GameObject Countdown;
    public AudioSource carbegin;
    public AudioSource carstart;
    public GameObject Laptimer;
    public GameObject Carcontrol;
    public AudioSource Levelmusic;

    void Start()
    {
        StartCoroutine(Countstart());
    }

    IEnumerator Countstart()
    {
        Laptimer.SetActive(false);
        Carcontrol.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        carbegin.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        carbegin.Play();
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        carstart.Play();
        Countdown.GetComponent<Text>().text = "1";
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Levelmusic.Play();
        Laptimer.SetActive(true);
        Carcontrol.SetActive(true);
    }

}
