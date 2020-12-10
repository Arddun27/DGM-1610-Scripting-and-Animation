using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private float speed = 10;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        MovePlayer();

        //Calling player rigid body so it can be used in this script 
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {  

    }

    // Making the player move using horizontal and vertical inputs by the player
    void MovePlayer()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * vInput);
        playerRb.AddForce(Vector3.right * speed * hInput);
    }

    //Everything will be inside 4 walls, didn't need to constrain
}
