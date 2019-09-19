using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
    GameObject[] portals;

  
	// Use this for initialization
	void Start () {
        if(gameObject.tag == "bluePortal") {
            portals = GameObject.FindGameObjectsWithTag("bluePortal");
        }
        else if (gameObject.tag == "greenPortal")
        {
            portals = GameObject.FindGameObjectsWithTag("greenPortal");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Vector3 teleportPosition = portals[Random.Range(0, portals.Length-1)].transform.position;
            other.gameObject.transform.position = teleportPosition;
            print(teleportPosition);
        }
    }
}
