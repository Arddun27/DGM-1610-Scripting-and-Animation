using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody playerRB;
    private GameObject focalPoint;
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
    }
}
