using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour {

    float startLife;
    public float lifeTime;

	// Use this for initialization
	void Start () {
        startLife = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time-startLife >= lifeTime)
        {
            Destroy(gameObject);
        }
	}
}
