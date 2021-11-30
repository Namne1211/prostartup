using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationController : MonoBehaviour
{
    Animator robotanimate;
    Transform tf;


    private void Start()
    {
        tf = GetComponent<Transform>();
        robotanimate = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void born()
    {
        robotanimate.SetBool("End", false);
        robotanimate.SetBool("Start",true);
    }
    public void end()
    {
        robotanimate.SetBool("Start", false);
        robotanimate.SetBool("End",true);
    }

    private void Update()
    {
    
        
    }
}
