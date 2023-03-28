using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : Bullet
{
    void Start()
    {
        speed *= 3;
        damageBullet = 3;
    }
}
