using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCoin : MonoBehaviour
{
    public float speed = 50.0f;

    void Update()
    {
        //move Coin forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}




















































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