using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAnimationPlayer : MonoBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}
    private Animator anim;

    public float newAnimationSpeed = 2f; 
    void Start () 
    { 
        //At the start of the game we assign the Animator component to our anim variable 
        anim = GetComponent<Animator>();
    }


    void Update () 
    { 
        //We check if player pressed the Space button 
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            //And set the playback speed of the whole Animator Controller (it multiplies all states animation playback speed) 
            anim.speed = newAnimationSpeed; 
        } 
    } 
    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
