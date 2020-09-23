using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float horizontalInput, verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.back * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);

         // get the user's horizontal input
        verticalInput = Input.GetAxis("Horizontal");

        // tilt the plane left/right based on left/right arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
