using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCoin : MonoBehaviour
{
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    float nextTimeTospawn;
    public GameObject[] CoinPrefabs;
    public float delay = 5f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", delay, spawnInterval);
    }
    // Update is called once per frame
    void SpawnCoin()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        int CoinIndex = (0); 
        Instantiate(CoinPrefabs[CoinIndex],spawnPos, CoinPrefabs[CoinIndex].transform.rotation); // Spawns a indexed coin from the array a random location on the X axis
    } 
}
