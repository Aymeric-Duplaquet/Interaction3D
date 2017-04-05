using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// GameObject camera;

	private Vector3 offset;


	// Use this for initialization
	void Start () {

		//Vector3 bodyOffset = new Vector3 (-0.05f, -0.15f, 0.05f);
		//+ bodyOffset
		offset = transform.position - Camera.main.transform.position ;

	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = Camera.main.transform.position + offset;

		transform.transform.Translate (0.15f, -0.35f, 0.1f);
	}
}
