using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToBoard : MonoBehaviour {

	//public GameObject student;
	public Transform sittingPosition;
	public Transform standingPosition;
	bool sitting = false;
	Animator animator;
	// Use this for initialization
	void Start () {
		//animator = student.gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			toggleTeleport ();
		}
	}

	void toggleTeleport(){
		if (sitting) {
			transform.position = standingPosition.position;
			//animator.runtimeAnimatorController = Resources.Load ("IK Animator Controller") as RuntimeAnimatorController;
			sitting = false;
		} else {
			transform.position = sittingPosition.position;
			//animator.runtimeAnimatorController = Resources.Load ("sitting") as RuntimeAnimatorController;
			sitting = true;
		}
	}
}
