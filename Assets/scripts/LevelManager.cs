using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class LevelManager : MonoBehaviour {
    public GameObject winImage;
    public GameObject loseImage;
    public int count = 0;
    public GameObject nextChapter;
    float startTime = 999999f;
    private int layer;
    //public int timer=120;
    //for now, we'll only control winning or losing here.
    //in the future, you can add a score count here, a timer,
    //high scores,etc.

	// Use this for initialization
	void Start () {
        layer = 1;
	}
	
	// Update is called once per frame
	void Update () {
        print(Time.time - startTime);
        if(Time.time - startTime > 3f)
        {
            SceneManager.LoadScene(1);
        }
		
	}
    public void lose(){
        loseImage.SetActive(true);
        Time.timeScale = 0;
    }
    public void win(){
        winImage.SetActive(true);
        if (layer == 2)
        {
            Time.timeScale = 0;
        }
        else
        {

        }

        NC();



    }
    public void NC()
    {
        layer++;
        nextChapter.SetActive(true);
        startTime = Time.time;
    }
}
