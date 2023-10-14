/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class countCoin : MonoBehaviour
{

    public TMP_Text coinText;
    public static countCoin instance;
    public int currentCoins = 0;
    // Start is called before the first frame update
    void awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void start()
    {
        coinText.text = "COINS: " + currentCoins.ToString();
    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText = "COINS: " + currentCoins.ToString();
    }
}
*/