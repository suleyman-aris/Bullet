using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticBullet : Bullet
{
    private void Start()
    {
        speed *= 2;
        damageBullet = 2;
    }
}
