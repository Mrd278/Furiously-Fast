using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour {
    public GameObject Pausemenuui;

    public static bool gameispaused = false; 
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
		
	}
    public void Resume()
    {
        Pausemenuui.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    void Pause()
    {
        Pausemenuui.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }
    public void quitgame()
    {
        Debug.Log("Quitting Game....");
        Application.Quit();
    }
}
