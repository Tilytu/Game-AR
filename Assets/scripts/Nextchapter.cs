using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextchapter : MonoBehaviour {
    LevelManager manager;
    // Use this for initialization
    void Start() {
        manager = GameObject.Find("GameControl").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            //tartCoroutine(manager.NC());
            manager.NC();
            Destroy(this.gameObject);
        }
    }
}
