using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour
{
    public float jumpHeight;
    Animator animator;
    private bool isJumping = false; // this doesn't need to be public
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping ) // both conditions can be in the same branch
        {
            rb.AddForce(Vector2.up * jumpHeight); // you need a reference to the RigidBody2D component
            isJumping = true;
            animator.SetBool("isJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        isJumping = false;
       animator.SetBool("isJumping", false);
    }
}