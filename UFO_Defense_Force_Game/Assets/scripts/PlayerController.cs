using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 23;
    public Transform blaster;
    public GameObject laserBolt;

    void Update()
    {
    //set horizontal input to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
    //moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    //keep player within boundaries
    //left side wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    //right side wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //space = fire laser bolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //create laserbolt at the blaster transform position maintaining the objects rotation
            Instantiate(laserBolt, blaster.position, laserBolt.transform.rotation);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
