using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Parent : MonoBehaviour
{

    public GameObject ball;
    [SerializeField]
    protected float min_reloading_time, max_reloading_time;//made this protected(Encapsulation)
    public Transform Spawn_Position;

    public IEnumerator Spawn_Bullets(float time)  //POLYMORHISM
    {
        while (!FindObjectOfType<GameManager>()._game_Over)
        {
            yield return new WaitForSecondsRealtime(time);
            Instantiate(ball,Spawn_Position.transform.position, ball.transform.rotation);
        }
    }

    public IEnumerator Spawn_Bullets(int time1,int time2)
    {
        while (!FindObjectOfType<GameManager>()._game_Over)
        {
            yield return new WaitForSecondsRealtime(time1);
            _ = Instantiate(ball,Spawn_Position.transform.position, ball.transform.rotation);  
            yield return new WaitForSecondsRealtime(time2);
        }
    }

}
