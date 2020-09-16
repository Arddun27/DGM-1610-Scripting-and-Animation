using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   private int speed = 200;
    private float turnSpeed = 100;
    private float hIinput, fInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
     
    hIinput = Input.GetAxis("Horizontal");
    //Move the Truck based on horizontal input
    fInput = Input.GetAxis("Vertical");
    //Move the Truck based on vertical input
    transform.Translate(Vector3.forward * Time.deltaTime * fInput);
    //Move the Truck based on horizontal input
    transform.Rotate(Vector3.up * Time.deltaTime * hIinput);
    }
}
