using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	public GameObject objectRotate;

	public float rotateSpeed = 500f;
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
			objectRotate.transform.Rotate (Vector3.forward, rotateSpeed * Time.deltaTime);
		}
	}

}
