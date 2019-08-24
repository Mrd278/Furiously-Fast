using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown1 : MonoBehaviour {

    public GameObject Countdown;
    public AudioSource carbegin;
    public AudioSource carstart;
    public GameObject Laptimer;
    public GameObject Carcontrol1;
    public AudioSource Levelmusic;
    public GameObject refree1;
    public GameObject refree2;

    void Start()
    {
        StartCoroutine(Countstart());
    }

    IEnumerator Countstart()
    {
        refree1.SetActive(false);
        refree2.SetActive(false);
        Laptimer.SetActive(false);
        Carcontrol1.SetActive(false);
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
        refree1.SetActive(true);
        refree2.SetActive(true);
        Laptimer.SetActive(true);
        Carcontrol1.SetActive(true);
    }

}
