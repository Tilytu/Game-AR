using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luncher : MonoBehaviour {
    Rigidbody body;
    public float thrustPower = 100f;
    // Use this for initialization
    void Start() {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Lander")
        {
            body.AddRelativeForce(Vector3.up * thrustPower);
        }
    }
}
