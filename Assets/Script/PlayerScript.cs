using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
            
	}

    void FixedUpdate()
    {
        transform.Translate(new Vector3(0, 0, -(Input.GetAxis("Vertical") / 100.0f)));
    }
}
