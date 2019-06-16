using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtStudent : MonoBehaviour {

	public Transform student;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (student) transform.LookAt (student);
	}
}
