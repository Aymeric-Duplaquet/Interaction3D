using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawmerScript : MonoBehaviour {

    //public GameObject carToSpawn;

	public static List <GameObject> carList = new List<GameObject>();

    private float nextSpawn;

	// Use this for initialization
	void Start () {

		//Load tous les prefabs qui sont dand le dossier "Assets/Ressources/Cars"
		Object[] subListObjects = Resources.LoadAll("Cars", typeof(GameObject));

		foreach (GameObject subListObject in subListObjects) 
		{    
			GameObject lo = (GameObject)subListObject;
			carList.Add(lo);
		}

		//Gestion de l'intervales
        nextSpawn = Random.Range(2, 10);
        nextSpawn += Time.time;

	}
	
	// Update is called once per frame
	void Update () {
		if(nextSpawn<Time.time)
        {
            newCar();
			//todo remettre 10
            nextSpawn = Random.Range(2, 10) + + Time.time;
        }
	}

    private void newCar()
    {


        //GameObject carT = GameObject.Instantiate(carToSpawn, transform);
		GameObject carT = GetRandomCars();
        carT.transform.position = transform.position;
        carT.transform.rotation = transform.rotation;
        carT.GetComponent<Rigidbody>().AddForce(carT.transform.forward * 500);
		if(carT.tag=="CarWhite") {
			carT.transform.Rotate(-90,0,0);
			//car.transform.Rotate(-90,0,0);
			//car.transform.eulerAngles.x = new Vector3(-90,0,0);
		} 

		if(carT.tag=="CarTruck") {
			carT.transform.Rotate(-90,-90,0);
		} 

		if(carT.tag=="CarBus") {
			carT.transform.Rotate(180,-90,0);
		} 

		if(carT.tag=="CarShelby") {
			carT.transform.Rotate(0,180,0);
		}


    }

	private GameObject GetRandomCars() 
	{    
		//Count le nomdre de voitures
		int max = carList.Count;
		//Random
		int index = Random.Range (0, max);
		//Instancie l'object
		GameObject car = Instantiate (carList  [index]) as GameObject;

		//aussi 
		//https://docs.unity3d.com/Manual/HOWTO-FixZAxisIsUp.html


		return car;

	}
}
