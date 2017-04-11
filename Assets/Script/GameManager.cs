using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int compteBalise;
    public TextMesh compteur;
    public GameObject nextLevel;
    

	// Use this for initialization
	void Start () {
        compteur.text = compteBalise.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void validateBalise()
    {
        Debug.Log("Hello");
        compteBalise--;
        compteur.text = compteBalise.ToString();

        if(compteBalise == 0)
        {
           
            nextLevel.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
