using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//Hilfsstruktur Aufzählung
public enum MyScenes
{
    Welcome,
    Main,
    End
}

public class Manager : MonoBehaviour
{
    //normale Text Komponente
    public InputField ipfKidsName;

    //Text mesh pro Komponente
    public TMP_InputField ipfKidsNameTMP;

    public TMP_Text displayKidsName;

    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        if(SceneManager.GetActiveScene().buildIndex == (int)MyScenes.Main)
        {
            Debug.Log("in Scene Main " + runtimeData.nameKid);

            displayKidsName.text = runtimeData.nameKid;
        }
    }

    //aus einem Skript wird eine Szene geladen
    public void SwitchTheScene(MyScenes x)
    {
        SceneManager.LoadScene((int)x);
    }

    //Aufruf in Inspector OnClick bei Button, generisch über
    //Parameter
    public void SwitchTheScene(int x)
    {
        Debug.Log("BTN Pressed, get kidsname " + ipfKidsName.text);

        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.Welcome)
        {
            runtimeData.nameKid = ipfKidsName.text;
        }
       

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
