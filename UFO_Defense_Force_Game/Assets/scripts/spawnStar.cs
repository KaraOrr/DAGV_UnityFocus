using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnStar : MonoBehaviour
{
    private float SpawnRangeX = 20f;
    private float SpawnPosZ = 20f;
    float nextTimeTospawn;
    public GameObject[] StarPrefabs;
    public float delayS = 10f;
    private float SpawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("triggerSpawnStar", delayS, SpawnInterval);
    }
    // Update is called once per frame
    void triggerSpawnStar()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX,SpawnRangeX),1,SpawnPosZ);
        int StarIndex = (0); 
        Instantiate(StarPrefabs[StarIndex],spawnPos, StarPrefabs[StarIndex].transform.rotation); // Spawns a indexed coin from the array a random location on the X axis
        Debug.Log("spawnstar");
    } 
}
