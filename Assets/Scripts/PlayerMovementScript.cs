using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    Vector2 movement;
    public Rigidbody2D rigidBody;

    private float speed = 5;

    private GameObject nearInteractObject;
    private GameObject nearInteractNPC;

    public List<Item> inventory = new List<Item>();
    public HeadGear headEquipped;
    public ChestGear chestEquipped;
    public LegsGear LegsEquipped;
    public Weapon mainWeapon;
    public Weapon offHandWeapon;
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
        if (Input.GetKeyDown(KeyCode.E) && nearInteractObject != null)
        {
            nearInteractObject.GetComponent<Chest>().Interact();
            inventory.Add(nearInteractObject.GetComponent<Chest>().loot);
        }
        else if (Input.GetKeyDown(KeyCode.E) && nearInteractNPC != null)
        {
            nearInteractNPC.GetComponent<NPCActionScript>().Interact();
        }
        else
        {
            
        }
    }
    void Move()
    {
        rigidBody.velocity = new Vector2(movement.x * speed, movement.y * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "InteractObject")
        {
            nearInteractObject = collision.gameObject;
        }
        if (collision.gameObject.tag == "NPC")
        {
            nearInteractNPC = collision.gameObject;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "InteractObject")
        {
            nearInteractObject = null;
        }
        if (collision.gameObject.tag == "NPC")
        {
            nearInteractNPC = null;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
