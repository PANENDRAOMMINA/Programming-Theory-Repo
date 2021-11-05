using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side_Moving_Turret : Turret_Parent   //inheriting from the turret parent
{
    private bool Positive;
    private Rigidbody rb;

    public void Awake()
    {
        _ = StartCoroutine(Spawn_Bullets(2,1));
        rb = GetComponent<Rigidbody>();
        Positive = true;

    }


    private void Update()
    {
        Toggle_Direction(); //abstracting the word (abstraction).
        Move_Sidewards();
    }

    private void Toggle_Direction()
    {
        if (transform.position.x > 1.5f)
            Positive = false;
        if (transform.position.x <-1.15f)
            Positive = true;
    }

    public void Move_Sidewards()
    {
        if (Positive)
            rb.velocity = Vector3.right;
        else
            rb.velocity = Vector3.left;
    }


}
