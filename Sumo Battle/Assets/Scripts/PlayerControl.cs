using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5, powerUpStrength = 5;
    private Rigidbody playerRB;
    private GameObject focalPoint;
    public bool hasPowerup = false;
    public GameObject powerUpIndicator;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float fInput = Input.GetAxis("Vertical");

        playerRB.AddForce(focalPoint.transform.forward * fInput * speed);

        powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Power Up"))
        {
            Destroy(other.gameObject);
            powerUpIndicator.gameObject.SetActive(true);
            hasPowerup = true;
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerUpIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
    if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
    {
        Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
        enemyRb.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        Debug.Log("Collided With: " + collision.gameObject.name + " with Power Up set to " + hasPowerup);
    }

    }
}
