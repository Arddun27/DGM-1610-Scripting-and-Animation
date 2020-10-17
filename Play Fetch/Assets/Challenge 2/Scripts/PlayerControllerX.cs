using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool spam = false;
    public int spamcount = 0;

    // Update is called once per frame
    void Update()
    {
        spamcount ++;
        // On spacebar press, send dog
        if(spamcount >= 50)
        {            
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
            spamcount = 0;
        }

        }
    }
}
