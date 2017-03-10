using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaliseScript : MonoBehaviour {

    public float timeToUpdate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            BaliseColor bal = hit.transform.GetComponent<BaliseColor>();
            if (bal != null)
            {
                bal.uptadeColor(Time.deltaTime);
            }
           
        }
        else
        {

        }
           

    }
}
