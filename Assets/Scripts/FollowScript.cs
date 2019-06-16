using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {
	public Transform target;
	public float xOffset = 0;
	public float yOffset = 0;
	public float zOffset = 0;
	public string targetTag = "Hand";
	public bool pointer = false;
	public bool matchRotation = false;
	public bool matchBoth = false;
	public bool modRotation = false;
	public float limit = 7.62f;
	Vector3 offset;

	public bool targeted = false;
	// Use this for initialization
	void Start () {
		offset = new Vector3 (xOffset, yOffset, zOffset);
	}
	
	// Update is called once per frame
	void LateUpdate () {

		offset = new Vector3 (xOffset, yOffset, zOffset);

		if (targeted && !target && GameObject.FindGameObjectWithTag (targetTag))
			target = GameObject.FindGameObjectWithTag (targetTag).transform;

		if (target && !matchRotation) {
			transform.position = target.transform.position + offset;
		}

		if (target && matchBoth) {
			transform.position = target.transform.position + offset;
			transform.rotation = target.transform.rotation;
		}

		if (pointer && transform.position.z > limit) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, limit);
		}

		if (matchRotation) {
			this.transform.rotation = target.transform.localRotation;
			if (modRotation) {
				transform.rotation *= Quaternion.Euler (xOffset, yOffset, zOffset);
			}
		}
	}


}
