using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Physics : MonoBehaviour
{
    
    public float acceleration;
    public float deceleration;
    public bool moving;
    private Rigidbody rb;

    public float t;
    public float rR;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("CheckSpeed", t, rR);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
        MovementDeceleration();
    }

    void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*acceleration);

        if (Input.GetAxis("Horizontal") != 0 | Input.GetAxis("Vertical") != 0) // GetAxisRaw va pasando por todos los valores entre 0 y 1, GetAxis es 0 o 1
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
    }

    void MovementDeceleration()
    {
        if(moving == false)
        {
            rb.angularDrag = deceleration;
        }
        else
        {
            rb.angularDrag = 0.05f;
        }
    }

    void CheckSpeed()
    {
        Debug.Log("Velocidad en X: " + rb.velocity.x);
        Debug.Log("Velocidad en Y: " + rb.velocity.y);
        Debug.Log("Velocidad en Z: " + rb.velocity.z);
    }
}
