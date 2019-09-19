using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() { }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Lander")
            {
                GetComponent<MeshRenderer>().material.color = new Color(148, 0, 211);
            }
        }
        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.name == "Lander")
            { 
                GetComponent<MeshRenderer>().material.color = new Color(0, 255, 255);
            }
        }
    }
