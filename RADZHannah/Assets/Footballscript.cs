using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footballscript : MonoBehaviour
{ 
Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

internal void kick()
{
        rb.AddExplosionForce(50000,
            transform.position + new Vector3(0, -1), 2);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
