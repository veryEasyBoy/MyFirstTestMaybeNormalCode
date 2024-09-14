using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Initialize : AnimationsPlayer
{
    private void Start()
    {
        InitPlayer();
        InitAnimations();
    }
    private void Update()
    {
        MoveInput();
        RotateInput();
        AnimatorMove();
    }
    private void FixedUpdate()
    {
        RaycastPlayer();
        JumpPlayer();
    }
}
