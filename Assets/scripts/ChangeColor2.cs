using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Lander")
        {
            GetComponent<MeshRenderer>().material.color = new Color(255, 0, 255);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Lander")
        {
            GetComponent<MeshRenderer>().material.color = new Color(255, 165, 0);
        }
    }
}
