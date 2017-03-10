using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaliseColor : MonoBehaviour {

    Material mat;
    public float validateTime;
    private float actualValidateTime;

	// Use this for initialization
	void Start () {
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    public void uptadeColor(float deltaTime)
    {
        actualValidateTime += deltaTime;
        float green = (actualValidateTime / validateTime);
        float red = 1 - green;

        GetComponent<Renderer>().material.color = new Color(red, green, 0);

        if(actualValidateTime >= validateTime)
        {
            gameObject.SetActive(false);
        }
    }
}
