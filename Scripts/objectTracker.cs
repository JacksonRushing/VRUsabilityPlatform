using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

public class objectTracker : MonoBehaviour 
{
    public List<trackedObject> trackedObjects;
    private SessionData data;

	void Start () 
	{
        trackedObject[] objects = GameObject.FindObjectsOfType<trackedObject>();
        foreach (trackedObject obj in objects)
        {
            trackedObjects.Add(obj);
        }
	}

    private void OnApplicationQuit()
    {
        List<TrackedObject>  objectDataList = new List<TrackedObject>();
        foreach (trackedObject obj in trackedObjects)
        {
            objectDataList.Add(obj.getDataForOutput());
        }

        Debug.Log("Object Data List Size: " + objectDataList.Count);

        SessionData sessionData = new SessionData(objectDataList);

        string jsonString = JsonConvert.SerializeObject(sessionData, Formatting.Indented);


        StreamWriter writer = new StreamWriter("Assets/" + sessionData.datetime + ".json", false);
        writer.Write(jsonString);
        writer.Close();
    }
}
