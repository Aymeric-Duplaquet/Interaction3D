using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour {


    //public List<GameObject> toShake;


    public float amplitude;
    public float periode;
    public Vector3 shakeDirection;

    private float frequence;
    private Vector3 initialPos;
    

	// Use this for initialization
	void Start () {
        initialPos = transform.position;
        shakeDirection = shakeDirection.normalized;
        if(periode==0)
        {
            frequence = 1;
        }
        else
        {
            frequence = 1 / periode;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tempDeplacement = (Mathf.Cos(Time.time * Mathf.PI * frequence) * amplitude * shakeDirection);
        transform.position = tempDeplacement + initialPos;
	}
}
