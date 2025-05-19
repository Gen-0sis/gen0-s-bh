using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    Rigidbody2D rb;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        rb.inertia = 0;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed;

        rb.velocity = movement;
    }
}
