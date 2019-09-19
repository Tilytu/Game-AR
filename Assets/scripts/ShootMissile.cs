using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootMissile : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform playercamera;
    GameObject missileInstance;
    public float missileSpeed = 50f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
        }
    }
    void shoot()
    {
        Vector3 missileposition = new Vector3(transform.position.x,
                                             transform.position.y,
                                             transform.position.z);
        Quaternion missileRotation = Quaternion.Euler(
         playercamera.eulerAngles.x,
         playercamera.eulerAngles.y,
         playercamera.eulerAngles.z);
        print(playercamera.rotation.y);
        missileInstance = Instantiate(missilePrefab, missileposition, missileRotation);
        missileInstance.GetComponent<Rigidbody>().velocity = transform.forward * missileSpeed;
        //Destroy(bulletInstance,5f);

    }
}
