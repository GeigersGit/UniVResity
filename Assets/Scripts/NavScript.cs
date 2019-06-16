using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NavScript : MonoBehaviour {

	UnityEngine.AI.NavMeshAgent agent;
	public Transform target;
	public float waitSeconds;
	public int targetNumber;
	GameObject container;
	Transform[] waypoints;
	public float distance;
	Animator an;
	Rigidbody rb;
	public float speed;
	public float divisor = 2;

	// Use this for initialization
	void Start () 
	{
		waitSeconds = 4;
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		an = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
		container = GameObject.Find ("Waypoints");
		waypoints = container.GetComponentsInChildren<Transform> ();

		//initial waypoint setup
		targetNumber = (int) Random.Range (1f, (float)waypoints.Length);
		target = waypoints [targetNumber];
		speed = .3f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//update animation
		//speed = (rb.velocity.magnitude)/divisor;
		an.SetFloat("Forward", speed, 0.3f, Time.deltaTime);

		//move to waypoint
		agent.SetDestination (target.position);

		//wait around and then go to a new waypoint
		if (waitSeconds < 0) 
		{
			
			targetNumber = (int)Random.Range (1f, (float)waypoints.Length);
			target = waypoints[targetNumber];
			waitSeconds = 4;
			speed = .3f;
		} 

		distance = Vector3.Distance (transform.position, target.position);
		if( distance < .5f)
		{
			waitSeconds -= Time.deltaTime;
			speed = 0f;
			target = transform;
		}
	}
}
