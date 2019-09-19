using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSound : MonoBehaviour {
    public AudioSource audioClip;
	// Use this for initialization
	void Start () {
       audioClip.Play();
        audioClip.Pause();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            audioClip.UnPause();
           
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            audioClip.Pause();
        }
	}
}
