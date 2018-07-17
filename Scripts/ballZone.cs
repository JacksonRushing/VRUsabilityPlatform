using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballZone : MonoBehaviour 
{
    public ScenarioController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.inBallZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.inBallZone = false;
        }
    }
}
