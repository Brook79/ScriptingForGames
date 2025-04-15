using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class SimpleNavMeshAgent : MonoBehaviour
{
    public Transform[] waypoints;
	public Transform target;
	private int currentWaypointIndex;
	private NavMeshAgent agent;
	public UnityEvent triggerRight;
	public UnityEvent triggerLeft;

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
		double wayY = (double)waypoints[0].position.y + 0.5;
		double waynegY = (double)waypoints[0].position.y - 0.5;
		double targetPos = (double)target.position.x;
		double targetY = (double)target.position.y;
		agent.stoppingDistance = 0.6f;
		if (way1Pos < targetPos && targetPos < way2Pos && waynegY < targetY && targetY < wayY)
		{
			agent.SetDestination(target.position);
			if (agent.transform.position.x < targetPos)
			{
				triggerRight.Invoke();
			}
			else
			{
				triggerLeft.Invoke();
			}
		}	
		else
		{
			if (agent.remainingDistance <= agent.stoppingDistance)
			{
				if (currentWaypointIndex == 0)
				{
					currentWaypointIndex = 1;
					triggerRight.Invoke();
				}
				else
				{
					currentWaypointIndex = 0;
					triggerLeft.Invoke();
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