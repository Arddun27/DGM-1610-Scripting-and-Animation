using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePreb;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float repeatDelay = 3, startDelay = 1;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatDelay);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        if(playerControllerScript.gameOver == false)
        {
        Instantiate(obstaclePreb, spawnPos, obstaclePreb.transform.rotation);
        }
    }
}
