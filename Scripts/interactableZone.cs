using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableZone : MonoBehaviour
{
    public ScenarioController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.inInteractableZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            controller.inInteractableZone = false;
        }
    }
}
