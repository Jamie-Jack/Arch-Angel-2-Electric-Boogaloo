using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {
	
	public NavMeshAgent Agent;
	public GameObject Player;
	void Update()
	{Agent.SetDestination (Player.transform.position);
	}
}