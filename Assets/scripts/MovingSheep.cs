using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSheep : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

            if (transform.position.x < 10f)
            {
               
                transform.position = new Vector3(transform.position.x ,
                    transform.position.y,
                    transform.position.z+0.03f);
            }
            if (Input.GetKey(KeyCode.Space))
                //move the cube to the left
                transform.position = new Vector3(transform.position.x - 0.09f,
                transform.position.y,
                transform.position.z);
        }
    }

