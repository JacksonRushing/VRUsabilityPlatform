using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGoalZone : MonoBehaviour 
{
    public ScenarioController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.inBallGoalZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.inBallGoalZone = false;
        }
    }
}
