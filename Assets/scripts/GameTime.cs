using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public float timer = 120;
    LevelManager manager;
    public Text countText;

    private void Start()
    {       
        manager = GameObject.Find("GameControl").GetComponent<LevelManager>();
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        SetCountText();
        if (timer < 0)
        {
            manager.lose();
         
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + timer.ToString();
    }
}
