using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed = 0.25f;
    private Rigidbody enemyRB, bossRB;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(lookDirection * speed);
        if (speed <= 1)
        {
            speed = 0.25f;
        }

       
    }

        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    //There isn't an off screen, just walls
}
