using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityAgent : Agent
{
    public enum eState
    {
        Idle,
        ActionStart,
        ActionInProgress,
        ActionComplete

    }

    [Range(0, 1)] public float utiliyThreshold = .25f;
    public bool utilityAI = true;

    //public float happiness
    //{
    //    //get
    //    //{
    //    //    float utility = 0;
    //    //    //foreach (var goal in goals) 
    //    //    //{
    //    //    //    utility += goal.utility;
    //    //    //}

    //    //    //return utility / goals.length;
    //    //}
    //}

    public eState State { get; set; } = eState.Idle;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Movement.Velocity.magnitude);
    }
}
