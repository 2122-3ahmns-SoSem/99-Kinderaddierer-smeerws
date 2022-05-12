using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Hilfsstruktur Aufzählung
public enum MyScenes
{
    Welcome,
    Main,
    End
}

public class Manager : MonoBehaviour
{
    //aus einem Skript wird eine Szene geladen
    public void SwitchTheScene(MyScenes x)
    {
        SceneManager.LoadScene((int)x);
    }

    //Aufruf in Inspector OnClick bei Button, generisch über
    //Parameter
    public void SwitchTheScene(int x)
    {
        Debug.Log("BTN Pressed");
        SceneManager.LoadScene(x);
    }

    public void SwitchTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //Jede Szene wird einzeln aufgerufen, muss dann auch 
    //für jede Szene eine Methode schreiben
    public void SwitchToEnd()
    {
        SceneManager.LoadScene((int)MyScenes.End);
    }
    public void SwitchToMain()
    {
        SceneManager.LoadScene((int)MyScenes.Main);
    }
    public void SwitchToWelcome()
    {
        SceneManager.LoadScene((int)MyScenes.Welcome);
    }
}
