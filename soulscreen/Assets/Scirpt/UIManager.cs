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
    public GameObject CareerUI;
    public GameObject CareerImagesUI;
    public GameObject MemoriesUI;
    public GameObject FamilyImagesUI;
    public GameObject AdvenuresImagesUI;
    public GameObject ChildhoodImagesUI;

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
        CareerUI.SetActive(false);
        MemoriesUI.SetActive(false);

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
    public void CareerScreen()
    {
        ClearScreen();
        CareerUI.SetActive(true);
    }
    public void CareerImagesScreenON()
    {
        CareerImagesUI.SetActive(true);
    }
    public void CareerImagesScreenOFF()
    {
        CareerImagesUI.SetActive(false);
    }
    public void MemoriesScreen()
    {
        ClearScreen();
        MemoriesUI.SetActive(true);
    }
            public void FamilyScreenON()
            {
                FamilyImagesUI.SetActive(true);
            }
            public void FamilyScreenOFF()
            {
                FamilyImagesUI.SetActive(false);
            }
            public void AdventuresScreenON()
            {
                AdvenuresImagesUI.SetActive(true);
            }
            public void AdventuresScreenOFF()
            {
                AdvenuresImagesUI.SetActive(false);
            }
            public void ChildhoodScreenON()
            {
                ChildhoodImagesUI.SetActive(true);
            }
            public void ChildhoodScreenOFF()
            {
                ChildhoodImagesUI.SetActive(false);
            }

}
