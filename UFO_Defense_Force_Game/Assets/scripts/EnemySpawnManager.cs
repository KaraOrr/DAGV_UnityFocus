using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{ 
    public GameObject[] ufoPrefabs; //array store ufo ships
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    
    private float startDelay = 1;
    private float spawnInterval = 1.5f;
    
    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    void Update()
    {

    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),1,spawnPosZ);
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); //picks a random ufo from the array
        Instantiate(ufoPrefabs[ufoIndex],spawnPos, ufoPrefabs[ufoIndex].transform.rotation); // Spawns a indexed UFO from the array a random location on the X axis
    } 
}
