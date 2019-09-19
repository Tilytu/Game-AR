using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controltables : MonoBehaviour {
    LevelManager manager;//now that we have a level manager script,
    //we can access it from other scripts.
    public int collectNum=1;
	// Use this for initialization
	void Start () {
        manager = GameObject.Find("GameControl").
            GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(45f, 0f, 0f) * Time.deltaTime);
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            if (++manager.count>=collectNum)
                manager.win();
         }
    }
}
