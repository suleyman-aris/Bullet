using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongWall : Wall
{
    private void Start()
    {
        health *= 2;
    }
}
