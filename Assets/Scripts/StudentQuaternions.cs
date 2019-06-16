using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentQuaternions : MonoBehaviour {

	public Quaternion[] quaternions;

	// Use this for initialization
	void Start () {
		quaternions = new Quaternion[50];
		for (int i = 0; i < 49; i++) {
			quaternions[i] = (Quaternion.identity);
		}
	}


	public void setQuaternion(int n, Quaternion q){
		quaternions[n] = q;
	}
	public Quaternion getQuaternion(int n){
		return quaternions [n];
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info){
		for (int i = 0; i < 49; i++) {
			stream.Serialize (ref quaternions[i]);
		}
	}
}
