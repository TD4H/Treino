using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private Animator animator;
    [SerializeField] private float moveSpeed;
    private float move;
    private bool jump;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            animator.SetTrigger("onGround");
        }
    }

    private void Update()
    {
        HandleMovimento();
        HandlePulo();
    }

    private void FixedUpdate()
    {
        controller.Move(move * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    private void HandleMovimento()
    {
        move = Input.GetAxisRaw("Horizontal") * moveSpeed;
        
        if (move == 0)
            animator.SetBool("move", false);
        else
            animator.SetBool("move", true);
    }

    private void HandlePulo()
    {
        if (Input.GetKeyDown(KeyCode.Space) && controller.GetGrounded())
        {
            jump = true;
            animator.SetTrigger("onJump");
        }
    }
}
