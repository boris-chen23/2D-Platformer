using UnityEngine;
using System.Collections;

public class Movement1 : MonoBehaviour
{

    public float speed;
    Animator animator;


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0.0f);

        animator.SetFloat("speed", Mathf.Abs(moveHorizontal* speed));

        rb.AddForce(movement * speed);
    } 
}