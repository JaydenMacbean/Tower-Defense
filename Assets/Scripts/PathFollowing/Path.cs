using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//verzameling van waypoints
public class Path : MonoBehaviour
{
    [SerializeField] private WayPoint[] _waypoints;
    GameObject currentWayPoint;


    public WayPoint GetPathStart()
    {
        return _waypoints[0];
    }
    public WayPoint GetPathEnd()
    {
        return _waypoints[_waypoints.Length - 1];
    }
    public WayPoint GetNextWaypoint(WayPoint currentWaypoint)
    {
        for (int i = 0; i < _waypoints.Length; i++)
        {
            if (_waypoints[i] == currentWaypoint)
            {
                return _waypoints[i + 1];
            }
        }
        return null;
    }
}
