using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class Carcontrol : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed =5f;
    public bool move = false;
    public bool grounded = true;
    public float rotationspeed = 0.5f;

    public float movementspeed = 5f;
    
    float movement = 0f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            move = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            move = false;
        }
        //movement = Input.GetAxis("Horizontal") * movementspeed;
        //Debug.Log(movement);
    }

    private void FixedUpdate()
    {
        
        if (move == true)
        {
            if(grounded == true)
            {
                
                //Vector2 velocity = rb.velocity;
               //velocity.x = movement;
                //rb.velocity = velocity;
                rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
                
            }
            else
            {
                rb.AddTorque( rotationspeed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)      
    {

        grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }

}
