using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollected : MonoBehaviour
{
    public int collected = 0;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin")){
        collected++;
        Debug.Log("coinCollected" + collected);
        Destroy(other.gameObject); //destroy other game object it hits
        }
    }
}


//