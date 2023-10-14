/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public GameObject CoinNum;
    public float speed = 10.0f;
    public float coinsManager;
    void Start()
    {
        OnTriggerEnter2D(Collider2D other)
    }


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (other.CompareTag ("coin"))
        {
            coinsManager.AddCoins (1);
            Destroy (other.gameObject);
        }
    }

    public void AddCoins (int amount)
    {
        coinsManager += amount;
    }
}
*/