using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;//bullet blueprint
    GameObject bulletInstance;//current bullet
    public float shootSpeed = 50f;
    public float shootHeight = 5f;
    public AudioSource sound;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0 )){
            //shoot!
            shoot();//call the shoot function
        }
	}
    void shoot()//define the shoot function
    {
        Vector3 bulletPosition = new Vector3(
            transform.position.x,
            transform.position.y+shootHeight ,
            transform.position.z);
        //set up the bullet popsition to be just above the player
        bulletInstance = Instantiate(bulletPrefab, bulletPosition,
            transform.rotation);
        //actually create the bullet!
        bulletInstance.GetComponent<Rigidbody>().velocity =
            transform.forward * shootSpeed;
        Destroy(bulletInstance, 5f);
        //garbage collection!
        sound.Play();

    }
}
