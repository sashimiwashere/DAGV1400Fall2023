using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 60;

    public float rotationSpeed = 90;

    public float gravity = -20f;

    public float jumpSpeed = 10;

    CharacterController characterController;

    Vector3 moveVelocity;

    Vector3 turnVelocity;


    void Start()
    {
        characterController = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        var hInput = Input.GetAxis("Horizontal");

        var vInput = Input.GetAxis("Vertical");

        if(characterController.isGrounded)
        {
            moveVelocity = transform.forward * vInput;
            turnVelocity = transform.up * rotationSpeed * hInput;

            if(Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpSpeed;
            }
        }

        moveVelocity.y += gravity * Time.deltaTime;

        characterController.Move(moveVelocity * Time.deltaTime);

        transform.Rotate(turnVelocity * Time.deltaTime);
    }
}
