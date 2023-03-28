using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected float speed = .1f;
    protected float damageBullet = 0;

    private void Update()
    {
        transform.position -= Vector3.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            other.gameObject.GetComponent<Wall>().damage = this.damageBullet;
            other.gameObject.GetComponent<Wall>().Life();
            this.gameObject.SetActive(false);
        }
    }
}
