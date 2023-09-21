using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WalkState: BaseState
{
    public override void EnterState()
    {

    }

    public override void HandleInput(InputAction.CallbackContext ctx)
    {
        input = moveAction.ReadValue<Vector2>();        
    }

    public override void PhysicsUpdate()
    {
        Vector3 movement = new Vector3(input.x, 0f, input.y) * character.playerSpeed * Time.deltaTime;
        movement = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * movement;
        movement = Vector3.ClampMagnitude(movement, 1) * 3;

        character.controller.Move(movement);
    }

    public override IStates CheckState()
    {
        if (!moveAction.triggered)
        {
            return new IdleState();
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
