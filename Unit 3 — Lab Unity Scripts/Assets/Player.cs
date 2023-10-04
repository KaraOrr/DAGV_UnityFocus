using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new : MonoBehaviour
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

        vector3 dir = new vector3(x, 0, z) * moveSpeed;

        rig.velocity = dir;
    }
}
