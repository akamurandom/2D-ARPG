using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int moveSpeed;
    [SerializeField] private Animator weaponAnimator;

    [System.NonSerialized] public int currentHealth;
    public int maxHealth;

    private Rigidbody2D rb;
    private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        currentHealth = maxHealth;
        GameManager.instance.UpdateHealthUI();
    }

    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(horizontal, vertical).normalized * moveSpeed;

        if (rb.velocity != Vector2.zero)
        {
            Debug.Log("*** " + horizontal + ", " + vertical);
            animator.SetFloat("X", horizontal);
            animator.SetFloat("Y", vertical);
            weaponAnimator.SetFloat("X", horizontal);
            weaponAnimator.SetFloat("Y", vertical);
        }

        if (Input.GetMouseButtonDown(0))
        {
            weaponAnimator.SetTrigger("Attack");
        }
    }
}
