using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class GhostNav : MonoBehaviour 
{

	public Transform player;

	private NavMeshAgent agent;

	void Update () 
	{
		agent = gameObject.GetComponent<NavMeshAgent>();

		agent.SetDestination(player.position);
	}

}