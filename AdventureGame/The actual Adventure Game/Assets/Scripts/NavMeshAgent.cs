using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleNavMeshAgent : MonoBehaviour
{
    public Transform[] waypoints;
	public Transform target;
	private int currentWaypointIndex;
	private NavMeshAgent agent;

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
	
	private void Update()
	{
		double way1Pos = (double)waypoints[0].position.x;
		double way2Pos = (double)waypoints[1].position.x;
		double targetPos = (double)target.position.x;
		agent.stoppingDistance = 0.6f;
		if (way1Pos < targetPos && targetPos < way2Pos)
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
					Debug.Log("1");
				}
				else
				{
					currentWaypointIndex = 0;
					Debug.Log("2");
				}
				agent.SetDestination(waypoints[currentWaypointIndex].position);
				Debug.Log("reached waypoint!");
			}
			else
			{
				agent.SetDestination(waypoints[currentWaypointIndex].position);
			}
		}
	}
}