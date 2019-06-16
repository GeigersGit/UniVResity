using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetQuaternion : MonoBehaviour {
	GameObject studentQuaternions;
	StudentQuaternions script;
	public int partNumber = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void LateUpdate () {
		if (!studentQuaternions && GameObject.FindGameObjectWithTag ("StudentQuaternions")) {
			studentQuaternions = GameObject.FindGameObjectWithTag ("StudentQuaternions");
			script = studentQuaternions.GetComponent<StudentQuaternions> ();
		} else {
			this.transform.localRotation = script.getQuaternion (partNumber);
		}
	}
}
