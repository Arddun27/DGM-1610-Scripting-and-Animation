using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateP : MonoBehaviour
{
    public int rot = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * rot *Time.deltaTime);
    }
}
