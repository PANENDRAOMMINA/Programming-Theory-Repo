using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float InputX = Input.GetAxis("Horizontal");
        float InputZ = Input.GetAxis("Vertical");

        Vector3 v = new Vector3(InputX, 0, InputZ);

        rb.velocity = v;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Finish"))
        {
            FindObjectOfType<GameManager>().win();
        }
        if(other.gameObject.CompareTag("Bullet"))
        {
            FindObjectOfType<GameManager>().Game_Over();
        }
    }
}
