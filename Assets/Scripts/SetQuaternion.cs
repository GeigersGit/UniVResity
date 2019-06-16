using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetQuaternion : MonoBehaviour {
	GameObject studentQuaternions;
	StudentQuaternions script;
	public int partNumber = 0;
	// Use this for initialization
	void Start () {
		
	}

	void LateUpdate () {
		if (!studentQuaternions && GameObject.FindGameObjectWithTag ("StudentQuaternions")) {
			studentQuaternions = GameObject.FindGameObjectWithTag ("StudentQuaternions");
			script = studentQuaternions.GetComponent<StudentQuaternions> ();
		} else {
			if(studentQuaternions)
				script.setQuaternion (partNumber, this.transform.localRotation);
		}
	}
}
