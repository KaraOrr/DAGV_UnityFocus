using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCoin : MonoBehaviour
{
    
    public GameObject Coin;
    public float collected = 0;
    public float delay = 5f;
    public float speed = 5f;
    float nextTimeTospawn;
void Start ()
{
    Coin = this.gameObject;
}
void Update() 
{
    // Moves the object forward at two units per second.
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
}
void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered collision with " + collision.gameObject.name);
        Destroy(Coin); //object dissappears
    }

void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered collision with " + other.gameObject.name);
        Destroy(Coin); //object dissappears
    }

}
//can i drop out of university now?




















































//     private void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.GameObject.CompareTag("Coin")) //if collision:
//         {
//             collected ++; //money counter goes up
//             Debug.Log(collected + "coins!");// print amount of coins
//             Destroy(GameObject); //object dissappears
//         }i
//     }
//  }

/*when game starts coin moves down
at the start of game, coin moves down at 5.0f; 
if (coin touches player), coin disappears, plus one to value, print how many coins you have
if else (coin leaves boundaries) coin destrroyed.

if (other.GameObject.CompareTag("PlayerController"))
        {
            Destroy(GameObject);
            countCoin.instance.IncreaseCoins(value);
        }

*/