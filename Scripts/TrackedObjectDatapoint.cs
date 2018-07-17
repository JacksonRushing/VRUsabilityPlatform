using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class TrackedObjectDataPoint
{
    public float time;
    public Vector3 position;
    public Quaternion rotation;

    public TrackedObjectDataPoint(float _time, Vector3 _position, Quaternion _rotation)
    {
        time = _time;
        position = _position;
        rotation = _rotation;


    }
}

public class TrackedObject
{
    public string name;
    public List<TrackedObjectDataPoint> points;

    public TrackedObject(string _name)
    {
        name = _name;
        points = new List<TrackedObjectDataPoint>();
    }

    public void addPoint(float _time, Vector3 _position, Quaternion _rotation)
    {
        points.Add(new TrackedObjectDataPoint(_time, _position, _rotation));
    }
}

public class SessionData
{
    public string datetime;
    public List<TrackedObject> objects;

    public SessionData(List<TrackedObject> _objects)
    {
        datetime = System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
        objects = _objects;
    }
}