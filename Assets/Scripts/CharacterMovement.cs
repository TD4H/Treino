using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private float move;
    private bool jump;
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float moveSpeeed;
    // Update is called once per frame

    private void Update()
    {
        HandleMovimento();
        HandlePulo();
    }

    void FixedUpdate()
    {
        controller.Move(move, false, jump);
    }

    void HandleMovimento()
    {
        move = Input.GetAxis("Horizontal") * moveSpeeed * Time.fixedDeltaTime;
    }
    void HandlePulo()
    {
        if (Input.GetKeyDown(KeyCode.Space) && controller.GetGrounded())
        {
            Debug.Log("Supostamente pulando");
            jump = true;
        }
        else
        {
            Debug.Log("Supostamente não pulando");
            jump = false;
        }
    }
}
