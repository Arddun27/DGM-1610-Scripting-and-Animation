using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   public int speed = 50;
    public float turnSpeed = 50;
    public float hIinput, fInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
     //Move the Truck
    hIinput = Input.GetAxis("Horizontal");
    fInput = Input.GetAxis("Vertical");

    transform.Translate(Vector3.forward * Time.deltaTime * fInput);
    transform.Rotate(Vector3.up * Time.deltaTime * hIinput);
    }
}
