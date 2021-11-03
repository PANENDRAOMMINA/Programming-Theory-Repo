using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Parent : MonoBehaviour
{

    public GameObject ball;
   [SerializeField]protected int reloading_time;

    public IEnumerator Spawn_Bullets(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Instantiate(ball, transform.position, ball.transform.rotation);
    }

}
