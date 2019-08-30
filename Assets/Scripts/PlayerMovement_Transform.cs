using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Transform : MonoBehaviour
{
    public Vector3 tempPos;
    public float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            tempPos = transform.position;
            tempPos.y += movement;
            transform.position = tempPos;
        }
        if (Input.GetKey(KeyCode.A))
        {
            tempPos = transform.position;
            tempPos.x -= movement;
            transform.position = tempPos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            tempPos = transform.position;
            tempPos.y -= movement;
            transform.position = tempPos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            tempPos = transform.position;
            tempPos.x += movement;
            transform.position = tempPos;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tempPos = transform.position;
            tempPos.y += movement;
            transform.position = tempPos;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tempPos = transform.position;
            tempPos.x -= movement;
            transform.position = tempPos;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempPos = transform.position;
            tempPos.y -= movement;
            transform.position = tempPos;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tempPos = transform.position;
            tempPos.x += movement;
            transform.position = tempPos;
        }
    }
}
