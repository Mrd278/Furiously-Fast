using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splashtomenu : MonoBehaviour {

    void Start()
    {
        StartCoroutine(ToMenu());   
    }

    IEnumerator ToMenu()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
