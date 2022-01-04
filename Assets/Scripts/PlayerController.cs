using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int moveSpeed;

    private Rigidbody2D rb;
    private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal, vertical).normalized * moveSpeed;

        if (rb.velocity != Vector2.zero)
        {
            animator.SetFloat("X", horizontal);
            animator.SetFloat("Y", vertical);
        }
    }
}
