using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    //Screen object variables
    public GameObject loginUI;
    public GameObject StartUI;
    public GameObject BioUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    //Functions to change the login screen UI

    public void ClearScreen() 
    {
        loginUI.SetActive(false);
        StartUI.SetActive(false);
        BioUI.SetActive(false);
    }

    public void LoginScreen() 
    {
        ClearScreen();
        loginUI.SetActive(true);
    }

    public void BioScreen()
    {
        ClearScreen();
        BioUI.SetActive(true);
    }
    public void StartScreen()
    {
        ClearScreen();
        StartUI.SetActive(true);
    }

}
