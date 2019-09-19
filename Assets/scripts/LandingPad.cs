using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingPad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Lander") {
            print("you win!");
            GetComponent<MeshRenderer>().material.color = new Color(255f, 0f, 255f);
      }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Lander")
        {
            print("no!");
            GetComponent<MeshRenderer>().material.color = new Color(255f, 0f, 0f);
        }
    }
}
