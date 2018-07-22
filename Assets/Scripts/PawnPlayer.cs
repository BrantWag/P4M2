using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnPlayer : Pawn
{

    public Transform tf;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Move(float direction)
    {
        tf.position += Vector3.right * direction * moveSpeed;
    }

    public override void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
}