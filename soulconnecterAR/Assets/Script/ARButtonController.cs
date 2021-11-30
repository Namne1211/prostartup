using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARButtonController : MonoBehaviour
{
    public GameObject StartAR;
    public GameObject BioAR;
    public GameObject ImageAR;
    public GameObject objectholder;
    string ButtonName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if(Physics.Raycast(ray,out Hit))
            {
                ButtonName = Hit.transform.name;
                switch (ButtonName)
                {
                    case "BioButton":
                        objectholder.SetActive(true);
                        StartAR.SetActive(false);
                        ImageAR.SetActive(false);
                        BioAR.SetActive(true);
                        break;
                    case "MemoryButton":
                        objectholder.SetActive(false);
                        StartAR.SetActive(false);
                        ImageAR.SetActive(true);
                        BioAR.SetActive(false);
                        break;
                    case "BackButton":
                        objectholder.SetActive(true);
                        StartAR.SetActive(true);
                        ImageAR.SetActive(false);
                        BioAR.SetActive(false);
                        break;
                }
            }
        }
    }
}
