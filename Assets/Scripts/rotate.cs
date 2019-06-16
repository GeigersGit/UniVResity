using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {


	bool rotated = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rotated) {
			transform.rotation = transform.rotation * new Quaternion (0, 1f, 0, 0.70710678118f);
			rotated = true;
		}
	}

	void LateUpdate(){
		
	}
}
