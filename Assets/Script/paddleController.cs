using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{
    // Start is called before the first frame update

    public KeyCode input;

    private HingeJoint hinge;
   
    private float springPower;
    private float targetPressed;
    private float targetReleased;


    private void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed   = hinge.limits.max;
        targetReleased  = hinge.limits.min;  
    }

    // Update is called once per frame

    private void Update()
    {
        ReadInput();
        MovePaddle();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = GetComponent<HingeJoint>().spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;

            Debug.Log("Pressed");
        } 
        else
        {
            jointSpring.targetPosition = targetReleased;
        }

        hinge.spring = jointSpring;


    }

    private void MovePaddle()
    {

    }
}
