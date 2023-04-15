using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float moveSpeed;
    private float move;
    private bool jump;

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
    }

    private void HandlePulo()
    {
        if (Input.GetKeyDown(KeyCode.Space) && controller.GetGrounded())
        {
            jump = true;
        }
    }
}
