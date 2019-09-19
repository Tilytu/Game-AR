using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCubes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < 10f)
        {
            //because this script is attached to the cube.
            //transform.positon refers to ITS POSITION.
            //transform.position.x is a float
            //transform.position is a Vector3
            //Vector3:a 3-d coordinate.

            //we need to add to the x position of the cube
            //to get it to move to the right.
            transform.position = new Vector3(transform.position.x + 0.05f,
                transform.position.y,
                transform.position.z);
        }
         if (Input.GetKey(KeyCode.Space))
            //move the cube to the left
            transform.position = new Vector3(transform.position.x - 0.09f,
            transform.position.y,
            transform.position.z);
        }
	}
