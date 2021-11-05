using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private float speed=80f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddForce(Vector3.back*speed*Time.deltaTime);
        if(transform.position.z<-7f)
        {
            Destroy(this.gameObject);
        }
    }


}
