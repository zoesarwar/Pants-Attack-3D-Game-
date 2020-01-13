using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeans : MonoBehaviour
{
    void OnTriggerEnter(Collider crash)
    {
        if (crash.CompareTag("Bullet"))
        {
            //Instantiate(effect, transform.position, Quaternion.identity);
            PlayerMovement.jeansLeft -= 1;
            Destroy(gameObject);
        }
    }
}
