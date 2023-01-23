using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;// player reference

    public float speed = 12f;
    public float gravity = -9.81f;
    public float JumpHeight = 3f;

    public Transform GroundCheck;// location of ground check
    public float groundDistance = 0.4f;// distance from ground
    public LayerMask groundMask;


    Vector3 velocity;// player velocity
    bool isGrounded;// grounded checker

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);// checks if physics sphere is colliding 

        if (isGrounded && velocity.y < 0)// if player is in the air
        {
            velocity.y = -2f;// players velocity is changed to -2 until they hit ground
        }

        if (Input.GetKeyDown(KeyCode.Escape))// if escape key pressed
        {
            Application.Quit();//quit
        }

        float x = Input.GetAxis("Horizontal");//x axis
        float z = Input.GetAxis("Vertical");//z axis

        Vector3 move = transform.right * x + transform.forward * z;//vector that calculates player distance 

        controller.Move(move * speed * Time.deltaTime);// moves the player (distance * speed * time)

        if(Input.GetButtonDown("Jump") && isGrounded)// if jumping and is grounded
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);// jumps
        }

        velocity.y += gravity * Time.deltaTime;// velocity is affected by gravity

        controller.Move(velocity * Time.deltaTime);// moves the player up or down
    }
}
