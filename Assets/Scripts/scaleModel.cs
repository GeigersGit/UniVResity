using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleModel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			float cameraHeight = Camera.main.transform.localPosition.y;
			float heightRatio = cameraHeight / 1.35f;
			Debug.Log (cameraHeight);
			this.transform.localScale *= heightRatio;
		}
	}
}
