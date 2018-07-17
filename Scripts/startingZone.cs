using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startingZone : MonoBehaviour 
{

    public ScenarioController controller;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            controller.inStartingPoint = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            controller.inStartingPoint = false;
        }
    }
}
