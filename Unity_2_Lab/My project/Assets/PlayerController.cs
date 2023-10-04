using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5;

    public float gravity = -30f;

    public float jumpForce = 15;

    public float sprintSpeed = 10;

    public float crouchSpeed = 2;

    public float standHeight = 2;

    public float crouchHeight = 1;

    public float rotationSpeed = 90;

    private bool crouch;

    private bool doubleJump;

    CharacterController characterController;

    Vector3 moveVelocity;

    Vector3 turnVelocity;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        var hInput = Input.GetAxis("Horizontal");

        var vInput = Input.GetAxis("Vertical");

        float mouseX = Input.GetAxis("Mouse X");

        if(characterController.isGrounded || doubleJump)
        {
            moveVelocity.x = moveSpeed * hInput;
            moveVelocity.z = moveSpeed * vInput;
            turnVelocity = transform.up * rotationSpeed * mouseX;
            
            if(Input.GetButtonDown("Jump") && !crouch) //jump
            {
                moveVelocity.y = jumpForce;
                doubleJump = !doubleJump;//double jump 
            }
            if(Input.GetKey(KeyCode.LeftShift)) //sprint
            {
                moveVelocity.x = sprintSpeed * hInput;
                moveVelocity.z = sprintSpeed * vInput;
            }
            if(Input.GetKey(KeyCode.LeftControl)) //crouch
            {
                moveVelocity.x = crouchSpeed * hInput;
                moveVelocity.z = crouchSpeed * vInput;
                characterController.height = crouchHeight;
                crouch = true;
            }
            if(Input.GetKeyUp(KeyCode.LeftControl)) //uncrouching
            {
                characterController.height = standHeight;
                crouch = false;
            }
        }

        moveVelocity.y += gravity * Time.deltaTime; //gravity

        characterController.Move(moveVelocity * Time.deltaTime);

        transform.Rotate(turnVelocity * Time.deltaTime);

    }
}
