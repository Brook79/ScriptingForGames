using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class BatNavMesh : MonoBehaviour
{
    public Transform[] waypoints;
    public Transform target;
    private int currentWaypointIndex;
    private NavMeshAgent agent;
    public GameObject thisObject;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        currentWaypointIndex = 0;
        if (waypoints.Length > 0)
        {
            agent.SetDestination(waypoints[0].position);
        }
    }
	
    public void Death()
    {
        Destroy(thisObject);
    }
	
    private void Update()
    {
        double way1Pos = (double)waypoints[0].position.x + 0.5;
        double way2Pos = (double)waypoints[1].position.x - 0.5;
        double wayY = (double)waypoints[0].position.y;
        double waynegY = (double)waypoints[0].position.y;
        double targetPos = (double)target.position.x;
        double targetY = (double)target.position.y;
        agent.stoppingDistance = 0.6f;
        if (way1Pos < targetY && targetY < waynegY && way2Pos < targetPos && targetPos < way1Pos)
        {
            agent.SetDestination(target.position);
        }	
        else
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (currentWaypointIndex == 0)
                {
                    currentWaypointIndex = 1;
                }
                else
                {
                    currentWaypointIndex = 0;
                }
                agent.SetDestination(waypoints[currentWaypointIndex].position);
            }
            else
            {
                agent.SetDestination(waypoints[currentWaypointIndex].position);
            }
        }
    }
}