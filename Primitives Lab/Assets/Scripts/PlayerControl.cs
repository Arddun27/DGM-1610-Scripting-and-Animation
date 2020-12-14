using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    public float speed = 5;
    private Rigidbody playerRb;
    public GameObject focalPoint;
    private int health = 3;
    private AudioSource playerAudio;
    public TextMeshProUGUI healthText, gameOverText;
    public Button restartButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
        //Calling player rigid body so it can be used in this script 
        playerRb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {  
       
    
    healthText.text = "HP:" + health;
    //MovePlayer();
    GameOver();


    focalPoint.transform.position = transform.position + new Vector3(0, 0, 0);
    
    
    
    
    }

    // Making the player move using horizontal and vertical inputs by the player
    void MovePlayer()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * vInput);
        playerRb.AddForce(Vector3.right * speed * hInput);
    }

    void OnCollisionEnter(Collision collision)
    {

    if (collision.gameObject.CompareTag("Enemy"))
    {
     health--;
    }

     if (collision.gameObject.CompareTag("Boss"))
    {
     health--;
    }

    }


private void GameOver()
{
    if (health <= 0)
    {
        gameOverText.gameObject.SetActive(true);
        health = 0;
        RestartGame();
    }
}    

    public void RestartGame()
    {
        SceneManager.LoadScene("StartScreen");
    }
   
 //Everything will be inside 4 walls, didn't need to constrain   
}