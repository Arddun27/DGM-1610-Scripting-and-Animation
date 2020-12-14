using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{ 
    public GameObject enemyPrefab, bossPrefab;
    private float spawnRange = 9;
    public int enemyCount, waveNumber = 1;
    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
       SpawnEnemyWave(waveNumber);
      
    }

    // Update is called once per frame
    void Update()
    {
        
        enemyCount = FindObjectsOfType<Enemies>().Length;

        if(enemyCount == 0)
        {
            waveNumber++;   
            SpawnEnemyWave(waveNumber);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
                
        for(int i = 0; i < enemiesToSpawn; i++)
        {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

        if (enemiesToSpawn % 5 == 1)
        {
        Instantiate(bossPrefab, GenerateSpawnPosition(), bossPrefab.transform.rotation);
        }
        
        
        
    }


    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange + 2, spawnRange);
        
        Vector3 randomPos =  new Vector3(spawnPosX, 1, spawnPosZ);

        return randomPos;
    }
}
