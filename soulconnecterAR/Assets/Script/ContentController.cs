using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentController : MonoBehaviour
{
    public List<GameObject> contents = new List<GameObject>();

    Transform tf;
    private void Start()
    {
        tf = GetComponent<Transform>();
    }
    public void LoadContent(int content)
    {
        DestroyAllChildren();
        Instantiate(contents[content], tf);
    }

    void OnContentLoaded(GameObject content)
    {
        //do something cool here
        Debug.Log("Loaded: " + content.name);
    }

    void DestroyAllChildren()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }   
}

