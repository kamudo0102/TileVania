using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    Vector2 input;
    float speed = 1f;   
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        
        if(input.magnitude > 0) 
        {
            input.Normalize();
        }
    }
}
