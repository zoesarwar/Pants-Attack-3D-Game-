using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter(Collider crash)
    {
        if (crash.CompareTag("Jean"))
        {
            Destroy(gameObject);
        }
    }

    public float life = 3;

    private void Start()
    {
        Destroy(gameObject, life);
    }
}
