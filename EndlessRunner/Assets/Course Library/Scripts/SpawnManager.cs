using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePreb;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float repeatDelay, startDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
    Instantiate(obstaclePreb, spawnPos, obstaclePreb.transform.rotation);
    }
}
