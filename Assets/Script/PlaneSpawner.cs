using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour {

	public int limitPlane=1;
	public int countPlane=0;

	public static List <GameObject> planeList = new List<GameObject>();

	private float nextSpawn;

	// Use this for initialization
	void Start () {

		//Load tous les prefabs qui sont dand le dossier "Assets/Ressources/Cars"
		Object[] subListObjects = Resources.LoadAll("Planes", typeof(GameObject));

		foreach (GameObject subListObject in subListObjects) 
		{    
			GameObject lo = (GameObject)subListObject;
			planeList.Add(lo);
		}

		newPlane();
		/*
		//Gestion de l'intervales
		nextSpawn = Random.Range(2, 10);
		nextSpawn += Time.time;
		*/
	}

	// Update is called once per frame
	void Update () {

		/* si on veut mettre une limite
		if(countPlane < limitPlane && nextSpawn < Time.time)
		{
			newPlane();
			//todo remettre 10
			nextSpawn = Random.Range(2, 5) + + Time.time;
				countPlane++;
		}
		*/
	}

	private void newPlane()
	{


			//GameObject carT = GameObject.Instantiate(carToSpawn, transform);
		GameObject plane = GetRandomPlanes();
		plane.transform.position = transform.position;
		plane.transform.rotation = transform.rotation;
		plane.GetComponent<Rigidbody>().AddForce(-(plane.transform.forward * 5000));
	/*
		if(carT.tag=="CarWhite") {
			carT.transform.Rotate(-90,0,0);
			//car.transform.Rotate(-90,0,0);
			//car.transform.eulerAngles.x = new Vector3(-90,0,0);
		} 

		if(carT.tag=="CarTruck") {
			carT.transform.Rotate(-90,-90,0);
		} 

		if(carT.tag=="CarBus") {
			carT.transform.Rotate(0,-90,180);
		} 

		if(carT.tag=="CarShelby") {
			carT.transform.Rotate(0,180,0);
		}
    */

	}

	private GameObject GetRandomPlanes() 
	{    
		//Count le nomdre de voitures
		int max = planeList.Count;
		//Random
		int index = Random.Range (0, max);
		//Instancie l'object
		GameObject plane = Instantiate (planeList  [index]) as GameObject;

		//aussi 
		//https://docs.unity3d.com/Manual/HOWTO-FixZAxisIsUp.html


	return plane;

	}
		
}
