using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Modescore.Currentscore += 100;
        gameObject.SetActive(false);
    }

}
