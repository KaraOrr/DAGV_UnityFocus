using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody rig;

    void update ()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        vector3 dir = transform.right * x + transform.forward * z;
        dir *= movespeed;
        dir.y = rig.velocity.y;

        rig.velocity = dir;
    }
}
