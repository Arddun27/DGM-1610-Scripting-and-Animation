using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumpForce, gravityMod;
    public bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            playerRB.AddForce(Vector3.up * 10, ForceMode. Impulse);
            isGrounded = false;
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(isGrounded);
        Debug.Log(other);
        isGrounded = true;
    }
}
