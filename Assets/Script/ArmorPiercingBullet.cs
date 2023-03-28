using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPiercingBullet : Bullet
{   
    void Start()
    {
        speed *= 5;
        damageBullet = 5;
    }
}
