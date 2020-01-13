using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFire : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100f;

    public GameObject player;
    public GameObject shootSound;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(player.transform.position, player.transform.forward, out hit))
        {
            Instantiate(shootSound, transform.position, Quaternion.identity);
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity = (hit.point - transform.position).normalized * speed;
            //Debug.Log(hit.transform.name);
        }
    }
}


