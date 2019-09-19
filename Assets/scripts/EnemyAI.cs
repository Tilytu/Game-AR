using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
     Transform player;
    public float attackDist = 390f;
    public float chaseSpeed = 15f;
    LevelManager manager;
    public AudioSource sound;
    // Update is called once per frame
    private void Start()
    {
        player = GameObject.Find("Player").transform;
        manager = GameObject.Find("GameControl").GetComponent<LevelManager>();
    }
    void Update()
    {//find the distance between the player and the enermy
        float dist = Vector3.Distance(
            player.position, transform.position);
        if (dist < attackDist)
        {
            //rotate towards the target
            LookAtPlayer();
            //move towards the target
            chase();

        }
    }
    void chase() {
        transform.position = Vector3.MoveTowards(
            transform.position, player.position,
            chaseSpeed * Time.deltaTime);
         sound.Play();
        //move enermy towards the player by chaseSpeed*Time.deltaTime units each frame.
        //Time.deltaTime is the amount of time each frame displays.
        //ex)if the game runs at 60fps,Time.deltaTime=1/60
        //so chaseSpeed*Time.deltaTime=10*(1/60)=1/6
        //which means that the enermy will move 1/6 of a unit
        //towards the player each frame.
    }
    void LookAtPlayer()
    {
        //rotate towards the player
        //create a vector that stores the direction from the enemy to the player
        float lookStartTime = Time.time;
        Vector3 dir = player .position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(dir);
        transform.rotation  = Quaternion.Lerp(
            transform.rotation, rotation,Time.time );
     }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision .gameObject .name =="Bullet(Clone)") {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Player")
        {
            manager.lose();
            Destroy(this.gameObject);
            //can shoot
            //enermies chase you
            //can kill enermies
            //can collect the collectable to show the win image
            //enermies can touch you and make you lose
        }
    }
}
