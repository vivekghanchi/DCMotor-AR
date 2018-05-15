using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explore : MonoBehaviour {

	public GameObject objectMove;

	public float moveSpeed = 0.1f;
	bool rotateStatus = false;

	public void Rotasi()
	{
		if (rotateStatus == false) {	
			rotateStatus = true;

		} else {
			rotateStatus = false;
		}
	}

	// Update is called once per frame
	// Use this for initialization

	void Update()
	{
		if (rotateStatus == true) {
			objectMove.transform.Translate(Vector3.up * moveSpeed);
		}
	}
}