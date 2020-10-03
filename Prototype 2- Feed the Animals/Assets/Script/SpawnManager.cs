using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
public GameObject[] animalPrefab;
public int animalIndex;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefab[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].Transform.rotation);
        }
    }
}
