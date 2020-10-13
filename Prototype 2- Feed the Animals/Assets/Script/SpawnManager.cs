using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangex = 10, spawnPosZ = 20, startDelay = 2, startInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

     void SpawnRandomAnimal()
    {
         int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos,  animalPrefabs[animalIndex].transform.rotation);
    }
}
