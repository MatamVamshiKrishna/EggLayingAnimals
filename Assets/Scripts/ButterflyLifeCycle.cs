using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine.UI;


// This script shows the complete lifecycle of
// the animal step by step

public class ButterflyLifeCycle : MonoBehaviour
{

 
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

    }
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("animation1"))
        {
        
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("animation2"))
        {
        
         


        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("animation3"))
        {
           
        }
    }


}
