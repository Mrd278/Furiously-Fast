using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonoptions : MonoBehaviour {
    public void Playgame()
    {
        SceneManager.LoadScene(5);
    }
    public void Trackselect()
    {
        SceneManager.LoadScene(2);
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Credits()
    {
        SceneManager.LoadScene(6);
    }
    public void Choicemenu()
    {
        SceneManager.LoadScene(7);
    }
    //below here are track selection buttons

    public void Track01()
    {
        SceneManager.LoadScene(3);
    }
    public void Track02()
    {
        SceneManager.LoadScene(4);
    }
    public void Track03()
    {
        SceneManager.LoadScene(5);
    }
    public void gbtmenu()
    {
        SceneManager.LoadScene(1);
    }
    public void selecttrack()
    {
        SceneManager.LoadScene(2);
    }
    public void quitgame()
    {
        Debug.Log("Quitting Game....");
        Application.Quit();
    }
}
