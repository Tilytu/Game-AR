using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {
 LevelManager manager;//now that we have a level manager script,
                      //we can access it from other scripts.

// Use this for initialization
void Start()
{
    manager = GameObject.Find("GameControl").
        GetComponent<LevelManager>();
}

// Update is called once per frame
void Update()
{
    transform.Rotate(new Vector3(45f, 0f, 0f) * Time.deltaTime);
}
private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.name == "Player")
    {
       
        
        Destroy(this.gameObject);

    }
    }
}
