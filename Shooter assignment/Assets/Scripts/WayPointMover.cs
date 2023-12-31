using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMover : MonoBehaviour
{

    [SerializeField] private WayPoints waypoints;

    [SerializeField] private float movespeed = 5f;


    [SerializeField] private float distanceThreshold = 0.1f;

    private Transform currentWaypoint;
    // Start is called before the first frame update
    void Start()
    {
        //start positie bepalen
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        //volgende waypoin target
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.LookAt(currentWaypoint);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, movespeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            transform.LookAt(currentWaypoint);
        }
    }
}
