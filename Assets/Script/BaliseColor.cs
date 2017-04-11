using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BaliseColor : MonoBehaviour {

	private int ratio=10;
    Material mat;
    public float validateTime;
    private float actualValidateTime;

    public UnityEvent action = new UnityEvent();

    // Use this for initialization
    void Start () {
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        actualValidateTime -= (Time.deltaTime / 3);
        if(actualValidateTime <0)
        {
            actualValidateTime = 0;
        }
        UpdateColor();
    }

    public void onLook(float deltaTime)
    {
        actualValidateTime += deltaTime;
       
    }

    void UpdateColor()
    {
		float green = (actualValidateTime / validateTime);
        float red = 1 - green;

        GetComponent<Renderer>().material.color = new Color(red, green, 0);

        if (actualValidateTime >= validateTime)
        {

            action.Invoke();
            gameObject.SetActive(false);

            
           
        }
    }
}
