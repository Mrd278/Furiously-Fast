using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachange : MonoBehaviour {
    public GameObject Normcam;
    public GameObject Farcam;
    public GameObject FPcam;
    public int Cammode;
	void Update () {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (Cammode == 3)
            {
                Cammode = 0;
            }
            else
            {
                Cammode += 1;
            }
            StartCoroutine(ModeChange());
        }
		
	}

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (Cammode == 0)
        {
            Normcam.SetActive(true);
            FPcam.SetActive(false);
        }
        if (Cammode == 1)
        {
            Farcam.SetActive(true);
            Normcam.SetActive(false);
        }
        if (Cammode == 0)
        {
            FPcam.SetActive(true);
            Farcam.SetActive(false);
        }
    }
}
