using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : Turret_Parent  
{
   
    public void Awake()
    {
        _ = StartCoroutine(Spawn_Bullets(Random.Range(min_reloading_time, max_reloading_time)));  
    }
}
