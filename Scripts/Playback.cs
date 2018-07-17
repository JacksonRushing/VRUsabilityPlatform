using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;


//drag file in
//press "load"
//loads in all data
//makes gameobject fields for all tracked objects

public class Playback : MonoBehaviour 
{
    public TextAsset sessionDataFile;
    public SessionData loadedData;
    public List<GameObject> linkedObjects;
    public Slider slider;
    public bool properlyLoaded = false;
    public playButton playButton;
    private float elapsedTimeThisPoint = 0.0f;

    void Start () 
	{
   
	}
	
	void Update () 
	{
        if(slider.value >= slider.maxValue)
        {
            playButton.playing = false;
        }
	}

    //get objectTracker from json file
    public bool loadJson()
    {
        if(Application.isPlaying)
        {
            Debug.Log("You did it!");

            //deserialize object
            loadedData = JsonConvert.DeserializeObject<SessionData>(sessionDataFile.text);
            //loadedData2 = JsonUtility.FromJson(sessionDataFile.text, typeof(objectData));

            foreach(TrackedObject obj in loadedData.objects)
            {
                Debug.Log(obj.name);
            }



            return true;
        }
        else
        {
            Debug.Log("Load while running the scene");
            return false;
        }
    }

 

    public void startPlaying()
    {
        if(playButton.playing)
            StartCoroutine(play());
    }

    IEnumerator play()
    {
        if (!playButton.playing)
            yield return null;

        while(playButton.playing && slider.value < slider.maxValue)
        {
            yield return new WaitForSeconds(loadedData.objects[0].points[(int)slider.value + 1].time - loadedData.objects[0].points[(int)slider.value].time);
            slider.value++;
        }
    }
    public void updatePlayback()
    {
        //Debug.Log(loadedData.objects[0].points[i].time);
        for (int j = 0; j < loadedData.objects.Count; j++)
        {

            if (linkedObjects[j] != null)
            {
                linkedObjects[j].transform.position = loadedData.objects[j].points[(int)slider.value].position;
                linkedObjects[j].transform.rotation = loadedData.objects[j].points[(int)slider.value].rotation;
                Debug.Log("updated!");
            }
        }

    }
}
