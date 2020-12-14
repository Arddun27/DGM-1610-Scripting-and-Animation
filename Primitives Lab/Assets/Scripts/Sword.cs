using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
   private Rigidbody swordRb;
   public Vector3 rotaionOffest;
   private GameObject focalPoint;
   public GameObject swordObj;

 void Start()
 {
    swordRb = GetComponent<Rigidbody>();
    
 }

 void Update()
 {
    if(Input.GetKeyDown(KeyCode.Space))
    {
       
    }

 }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Boss"))
        {
            Destroy(other.gameObject);
        }

    }
}
