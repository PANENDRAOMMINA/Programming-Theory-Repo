using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : Turret_Parent
{
    public void Awake()
    {
        StartCoroutine(Spawn_Bullets(reloading_time));
    }
}
