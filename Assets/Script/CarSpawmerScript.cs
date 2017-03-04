using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawmerScript : MonoBehaviour {

    public GameObject carToSpawn;

    private float nextSpawn;

	// Use this for initialization
	void Start () {
        nextSpawn = Random.Range(2, 10);
        nextSpawn += Time.time;

	}
	
	// Update is called once per frame
	void Update () {
		if(nextSpawn<Time.time)
        {
            newCar();
            nextSpawn = Random.Range(2, 10) + + Time.time;
        }
	}

    private void newCar()
    {
        GameObject carT = GameObject.Instantiate(carToSpawn, transform);
        carT.transform.position = transform.position;
        carT.transform.rotation = transform.rotation;
        carT.GetComponent<Rigidbody>().AddForce(carT.transform.forward * 500);
    }
}
