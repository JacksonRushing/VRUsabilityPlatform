using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playButton : MonoBehaviour 
{
    public bool playing = false;

    public void pressed()
    {
        playing = !playing;
    }
}
