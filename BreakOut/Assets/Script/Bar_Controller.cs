using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_Controller : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(7f,0f);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-7f,0f);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
