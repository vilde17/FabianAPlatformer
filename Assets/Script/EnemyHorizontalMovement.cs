using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isleft = true;

    private Rigidbody2D rbody;
    // Use this for initialization

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EndPlatform")
        {
            if (isleft == true)
            {
                isleft = false;
                transform.Rotate(0, 180, 0);
            }
            else
            {
                isleft = true;
                transform.Rotate(0, 180, 0);
            }
        }
    }

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isleft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
        }

    }
    void Move(bool flip)
    {
        if (isleft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}        // Annat sätt att göra det transform.localScale = new Vector3(movespeed, rbody.velocity.y

