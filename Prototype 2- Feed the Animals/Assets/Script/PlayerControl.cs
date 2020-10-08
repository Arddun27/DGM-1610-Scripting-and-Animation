using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float hInput, speed = 10f;
    public GameObject projectileprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // Collecting the input
        hInput = Input.GetAxis("Horizontal");
        //Using input
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);

        if(transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

         if(transform.position.x > 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
            
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a Projectile from player
            Instantiate(projectileprefab, transform.position, projectileprefab.transform.rotation);
        }
        

    }
}
