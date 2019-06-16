using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {
	public Transform target;
	public string targetTag;
	public bool targeted = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (targeted) {
			if (!target) {
				if (GameObject.FindGameObjectWithTag (targetTag)) {
					target = GameObject.FindGameObjectWithTag (targetTag).transform;
				}
			}
		}


		transform.LookAt(target);
	}
}
