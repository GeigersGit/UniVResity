using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavFollow : MonoBehaviour {
	Animator an;
	UnityEngine.AI.NavMeshAgent agent;
	public Transform target;
	float speed = .3f;
	float distance;
	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		an = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);
		distance = Vector3.Distance (transform.position, target.position);
		if (distance < .2f) {
			speed = 0f;
		} else {
			speed = 0.3f;
		}
		an.SetFloat ("Forward", speed, 0.3f, Time.deltaTime);
	}
}
