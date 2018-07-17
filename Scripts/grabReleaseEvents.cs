using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class grabReleaseEvents : MonoBehaviour
{

    void Start()
    {

	}
	
	void Update ()
    {
		
	}

    public void logGrab()
    {
        Debug.Log(gameObject.name + " grabbed!");
    }
    public void logRelease()
    {
        Debug.Log(gameObject.name + " released!");
    }
}
