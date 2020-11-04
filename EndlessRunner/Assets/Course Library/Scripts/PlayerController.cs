using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Animator playerAnim;
    public float jumpForce = 700, gravityMod = 1.5f;
    public bool isGrounded = true, gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityMod;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true && !gameOver)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            playerAnim.SetTrigger("Jump_trig");
        }
        
    }

    void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.CompareTag("Ground"))
        {
        isGrounded = true;
        }

        else if(other.gameObject.CompareTag("Obstacle"))
        {
        Debug.Log("Git Gud Scrub");
        gameOver = true;
        playerAnim.SetBool("Death_b", true);
        playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
