using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollected : MonoBehaviour
{
    public int Stars = 0;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("star")){
        Stars++;
        Debug.Log("starCollected ");
        Destroy(other.gameObject); //destroy other game object it hits
        }
    }
}

