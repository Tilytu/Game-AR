using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    public Transform lander;
    Vector3 offset;
    Transform coolTransform;
 
	// Use this for initialization
	void Start () {
        offset = transform.position - lander.position;
        //store the difference in position between the camera
        //and lander at the start of the game.
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPositon = lander.position + offset;
        transform.position = newPositon;

	}
}
