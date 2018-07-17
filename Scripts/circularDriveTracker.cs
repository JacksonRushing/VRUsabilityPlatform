using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class circularDriveTracker : MonoBehaviour 
{
    public ScenarioController controller;
    private CircularDrive drive;
	void Start () 
	{
        drive = gameObject.GetComponent<CircularDrive>();
	}

    void Update()
    {
        if (drive.outAngle >= 360 || drive.outAngle <= -360)
        {
            controller.interacted = true;
        }
	}
}
