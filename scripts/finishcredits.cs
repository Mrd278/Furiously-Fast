using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishcredits : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CreditEnd());
    }
    IEnumerator CreditEnd()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(1);
    }
}
