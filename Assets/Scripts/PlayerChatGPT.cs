using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 6.0f;
    //public float jumpHeight = 2.0f;
    //public float jumpDuration = 0.5f;

    //private bool isJumping = false;
    //private float jumpStartTime;
    //private Vector3 initialPosition;


    void Update()
    {

        Vector3 lInputVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical")) * moveSpeed * Time.deltaTime;

        // Move the character
        //transform.Translate(lInputVector);
        //transform.position += lInputVector;
        transform.position = transform.position + lInputVector;

        //if (!isJumping && Input.GetButtonDown("Jump"))
        //{
        //    // Start the jump
        //    isJumping = true;
        //    jumpStartTime = Time.time;
        //    initialPosition = transform.position;
        //}

        //if (isJumping)
        //{
        //    // Calculate jump progress
        //    float jumpProgress = (Time.time - jumpStartTime) / jumpDuration;

        //    // Check if the jump is complete
        //    if (jumpProgress >= 1.0f)
        //    {
        //        isJumping = false;
        //        jumpProgress = 1.0f;
        //    }

        //    // Calculate the jump height based on a quadratic curve
        //    float jumpHeightOffset = Mathf.Sin(jumpProgress * Mathf.PI);
        //    Vector3 jumpPosition = initialPosition + Vector3.up * jumpHeight * jumpHeightOffset;

        //    // Apply the jump position
        //    transform.position = jumpPosition;
        //}
    }
}
