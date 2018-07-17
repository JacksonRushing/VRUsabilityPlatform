using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGoal : MonoBehaviour 
{
    public ScenarioController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            controller.ballInGoal = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            controller.ballInGoal = false;
        }
    }
}
