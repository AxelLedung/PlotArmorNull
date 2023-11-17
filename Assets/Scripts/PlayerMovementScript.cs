using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    Vector2 movement;
    public Rigidbody2D rigidBody;

    private float speed = 5;

    public bool eKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        Move();
    }
    
    void ProcessInput()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
       
        
    }
    void Move()
    {
        rigidBody.velocity = new Vector2(movement.x * speed, movement.y * speed);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "InteractObject")
        {
            Debug.Log(1);
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(2);
            }
        }
        Debug.Log(3);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log(4);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
           
        }
    }
}
