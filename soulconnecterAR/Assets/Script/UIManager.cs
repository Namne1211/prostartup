using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject MymemoryBoxScreen;
    public GameObject MymemoryBoxDataScreen;
    // Start is called before the first frame update
    void Closeall()
    {
        startScreen.SetActive(false);
        MymemoryBoxScreen.SetActive(false);
        MymemoryBoxDataScreen.SetActive(false);
    }

    public void ARButton()
    {
        SceneManager.LoadScene(1);
    }
    public void CloseApp()
    {
        Application.Quit();    
    }

    public void StartScreen()
    {
        Closeall();
        startScreen.SetActive(true);
    }
    public void MyMemoryBoxScreen()
    {
        Closeall();
        MymemoryBoxScreen.SetActive(true);
    }
    public void MyMemoryBoxDataScreen()
    {
        Closeall();
        MymemoryBoxDataScreen.SetActive(true);
    }
}
