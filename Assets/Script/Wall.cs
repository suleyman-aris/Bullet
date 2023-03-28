using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Wall : MonoBehaviour
{
    public float health = 5;
    public float damage = 0;

    public void Life()
    {
        health -= damage;
        Die();
    }

    public void Die()
    {
        if (health <= 0)
            this.gameObject.SetActive(false);
    }
}
