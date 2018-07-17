using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class jsonTest : MonoBehaviour 
{

	void Start () 
	{
        string path = "Assets/test.json";

        TrackedObjectDataPoint point1 = new TrackedObjectDataPoint(Time.time, new Vector3(1, 1, 1), Quaternion.identity);
        TrackedObjectDataPoint point2 = new TrackedObjectDataPoint(Time.time, new Vector3(2, 2, 2), Quaternion.identity);

        List<TrackedObjectDataPoint> points = new List<TrackedObjectDataPoint>();
        points.Add(point1);
        points.Add(point2);

        string jsonString = JsonConvert.SerializeObject(points, Formatting.Indented);


        StreamWriter writer = new StreamWriter(path, false);
        writer.Write(jsonString);
        writer.Close();
    }
	
	void Update () 
	{
		
	}
}
