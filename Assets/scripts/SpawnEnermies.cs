using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnermies : MonoBehaviour {
    public GameObject enermyPrefab;
    public float spawnTime = 3f;
	// Use this for initialization
	void Start () {
        //call the function spwan ()every 3 seconds,
        //and start doing this in 1 second from now.
        InvokeRepeating("spawn",1f,spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void spawn()
    {
        Vector3 enermyPosition = new Vector3(
            Random.Range(0f, 500f),
            Random.Range(2f, 10f),
            Random.Range(0f, 500f));
        Instantiate(enermyPrefab,
            enermyPosition,
            enermyPrefab.transform.rotation);
    }
}
