using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//broadcast events on 
public class ScenarioController : MonoBehaviour
{

    // **** maybe add gaze thing? ****
    //1. Move to starting point
    //2. Walk over to ball
    //3. Pick up ball
    //4. Walk to goal 
    //5. Place ball on goal
    //6. Walk to circular drive
    //7. Spin circular drive

    public GameObject startingArea;
    public GameObject ballArea;
    public GameObject ball;
    public GameObject goalArea;
    public GameObject goal;
    public GameObject interactableArea;
    public GameObject interactable;
    public GameObject player;

    public bool inStartingPoint = false;
    public bool inBallZone = false;
    public bool ballInHand = false;
    public bool inBallGoalZone = false;
    public bool ballInGoal = false;
    public bool inInteractableZone = false;
    public bool interacted = false;

    //Progress represents the progress through the scenario
    //If progress is equal or greater to the above number of a task, that task has been completed.
    private int progress = 0;

	void Start ()
    {
		
	}

    void Update()
    {
        if (progress == 0)
        {
            //check if on starting point
            if (inStartingPoint == true)
            {
                progress = 1;
                StartCoroutine(setInactiveDelay(startingArea, 1.0f));
                Debug.Log("Progress = " + progress);
            }
        }

        else if (progress == 1)
        {
            //check if in ball area
            if (inBallZone == true)
            {
                progress = 2;
                Debug.Log("Progress = " + progress);
            }
        }

        else if (progress == 2)
        {
            //check if ball is picked up
            if(ballInHand)
            {
                progress = 3;
                Debug.Log("Progress = " + progress);
            }

        }

        else if (progress == 3)
        {
            //check if in goal area
            if (inBallGoalZone)
            {
                progress = 4;
                Debug.Log("Progress = " + progress);
            }
        }

        else if (progress == 4)
        {
            //check if ball in goal
            if (ballInGoal == true)
            {
                progress = 5;
                Debug.Log("Progress = " + progress);
            }
        }

        else if (progress == 5)
        {
            //check if in interactable area
            if (inInteractableZone == true)
            {
                progress = 6;
                Debug.Log("Progress = " + progress);
            }       
        }

        else if (progress == 6)
        {
            //check if interacted
            if(interacted == true)
            {
                progress = 7;
                Debug.Log("Progress = " + progress);
                Debug.Log("done!!");    
            }
        }

        else if (progress == 7)
        {
            //done!
            
        }
    }

    private IEnumerator setInactiveDelay(GameObject _obj, float _time)
    {
        yield return new WaitForSeconds(_time);
        _obj.SetActive(false);
    }

    public void setBallStatus(bool _inHand)
    {
        ballInHand = _inHand;
    }
}
