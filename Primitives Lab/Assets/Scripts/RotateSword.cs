using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSword : MonoBehaviour
{
    public float rotateSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
        
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    if (Input.GetKeyDown(KeyCode.L))
        {
        
        transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        }

        

        float hInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hInput * rotateSpeed * Time.deltaTime);
    }
}
