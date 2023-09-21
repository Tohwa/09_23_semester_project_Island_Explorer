using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class IdleState : BaseState
{
    #region Fields
    float gravityValue;
    float playerSpeed;

    bool crouch;
    bool jump;
    bool grounded;
    bool sprint;

    Vector3 currentVelocity;
    #endregion

    public override void EnterState()
    {
        crouch = false;
        jump = false;
        sprint = false;
        input = Vector3.zero;
        Velocity = Vector3.zero;
        currentVelocity = Vector3.zero;
        gravityVelocity.y = 0;
        playerSpeed = character.playerSpeed;
        gravityValue = character.gravityValue;
    }

    public override void HandleInput(InputAction.CallbackContext ctx)
    {

    }

    public override IStates CheckState()
    {
        if (moveAction.triggered)
        {
            return new WalkState();
        }

        if (jumpAction.triggered)
        {
            return new JumpState();
        }

        if (crouchAction.triggered)
        {
            return new CrouchState();
        }

        if (sprintAction.triggered)
        {
            return new SprintState();
        }

        return null;
    }

    public override void ExitState()
    {

    }

}
