using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    Vector2 speed = new Vector2  (5f,5f); //ボールの初速度
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }
  
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Block"))
        {
            Destroy(other.gameObject);
        } 
    }
}
