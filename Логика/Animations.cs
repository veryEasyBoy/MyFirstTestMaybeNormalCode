using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class AnimationsPlayer : MoveController
{
    protected Animator animator;
    protected void InitAnimations()
    {
        animator = GetComponent<Animator>();
    }

    protected void AnimatorMove()
    {
        if (moveY > 0 || moveY < 0)
        {
            animator.SetBool("MoveY", true);
            // animator.SetBool("air",false);


        }
        else
        {
            animator.SetBool("MoveY", false);
        }


        if (moveX > 0 || moveX < 0)
        {
            animator.SetBool("MoveX", true);

        }
        else
        {
            animator.SetBool("MoveX", false);
        }

        AnimatorJump();

        animator.SetFloat("vectorY", moveY);
        animator.SetFloat("vectorY", moveY);
        animator.SetFloat("vectorX", moveX);
        animator.SetFloat("vectorX", moveX);
    }
    protected void AnimatorJump()
    {
        if (isGrounded)
        {
            animator.SetBool("air", false);
            if (Input.GetKeyDown(KeyCode.Space))
            {
               // PlaySoundAll(sounds[0]);
                animator.SetTrigger("Jump");
            }
        }
        else
        {
            animator.SetBool("air", true);

        }
    }
}
