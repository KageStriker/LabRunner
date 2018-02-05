using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobManager : MonoBehaviour
{
    private bool grounded;
    private Rigidbody2D rb;
    
    private void Start()
    {
        IsGrounded();

        if (rb == null)
            rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    public void IsGrounded()
    {
        grounded = true;
    }

    public void NotGrounded()
    {
        grounded = false;
    }
}
