using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class MoveController : GroundCheck
{
    protected float moveX;
    protected float moveY;
    [SerializeField] private float moveSpeed = 10;
    private Vector3 rotationPlayer;
  

    protected void MoveInput()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        moveY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(moveX, 0, moveY);
    }
    protected void RotateInput()
    {
        transform.Rotate(Vector3.up * 100f * Time.deltaTime * Input.GetAxis("Horizontal"));
        rotationPlayer.x -= Input.GetAxis("Vertical") * 100f * 100 * Time.deltaTime;
    }
    protected void JumpPlayer()
    {
        if (Input.GetButton("Jump") && isGrounded)
        {
            rb.AddForce(transform.up * moveSpeed * 60);
        }
    }
}
