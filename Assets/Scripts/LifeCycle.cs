using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine.UI;


// This script shows the complete lifecycle of
// the animal step by step

public class LifeCycle : MonoBehaviour
{

    public Text DayCount;
    public float Count = 0;
    public float time;

    private bool Chick = false;
    private Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }
        void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("LayingEggs"))
        {
            Count = 1;
            DayCount.text = "Day :" + Count;
            time = Time.time;
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SittingOnEggs"))
        {
            if(Chick == false)
            {
                Chick = true;
                Count += 1;
                Debug.Log(time);
            }
            float Length = animator.GetCurrentAnimatorStateInfo(0).length;
            float Factor = (Length / 21);

            if(Time.time >= time+Factor)
            {
                time = Time.time;
                Count++;
                Debug.Log(time);
                Debug.Log(Count);
            }
            Debug.Log(Length);
            Debug.Log(Factor);
            

          
            DayCount.text = "Day :" + Count;
           
           
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("EggsHatching"))
        {
            Count = 22;
            DayCount.text = "Day :" + Count;
        }
    }

  
}
