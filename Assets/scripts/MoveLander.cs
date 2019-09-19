using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLander : MonoBehaviour {
    //this is the place we setup variables
    Rigidbody body;//define a variable of type rigidbody
    public float spinPower = 20f;
    public float thrustPower = 20f;
    public int MoveSpeed=15;
	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {//move up
        
            body.AddRelativeForce(Vector3.up * thrustPower);
        }
        if (Input.GetKey(KeyCode.D))
        { //move right
            this.transform.Translate(Vector3.right*Time.deltaTime*MoveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        { //move left
            this.transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        { //move down
            this.transform.Translate(Vector3.down * Time.deltaTime * MoveSpeed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "happy")
        {
            body.AddRelativeForce(Vector3.up * 1500f);
        }
    }
}
