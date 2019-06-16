using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseToWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		Physics.Raycast(ray, out hit, float.PositiveInfinity);
		this.transform.position = hit.point;
	}
}
