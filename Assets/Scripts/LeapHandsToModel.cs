using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapHandsToModel : MonoBehaviour {

	public Transform leapRightElbow = null;
	public Transform RightElbow = null;
	public Transform leapRightWrist = null;
	public Transform RightWrist = null;

	void LateUpdate(){
		if (leapRightElbow != null) {
			RightElbow.transform.position = leapRightElbow.transform.position;
			RightElbow.transform.rotation = leapRightElbow.transform.rotation;
		}

		if (leapRightWrist != null) {
			RightWrist.transform.position = leapRightWrist.transform.position;
			RightWrist.transform.rotation = leapRightWrist.transform.rotation;
		}
	}
}
