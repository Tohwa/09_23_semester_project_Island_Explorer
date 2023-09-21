using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class BaseState : IStates
{
    #region Fields
    public Character character;
    public StateMachine stateMachine;

    protected Vector3 gravityVelocity;
    protected Vector3 Velocity;
    protected Vector2 input;

    public InputAction moveAction;
    public InputAction lookAction;
    public InputAction jumpAction;
    public InputAction crouchAction;
    public InputAction sprintAction;
    #endregion
    
    public BaseState()
    {
        moveAction = character.playerInput.actions["Move"];
        lookAction = character.playerInput.actions["Look"];
        jumpAction = character.playerInput.actions["Jump"];
        crouchAction = character.playerInput.actions["Crouch"];
        sprintAction = character.playerInput.actions["Sprint"];
    }

    public virtual void EnterState()
    {
        Debug.Log("Player is now in:" + this.ToString());
    }

    public virtual IStates CheckState()
    {
        return null;
    }

    public virtual void HandleInput()
    {

    }

    public virtual void LogicUpdate()
    {

    }

    public virtual void PhysicsUpdate()
    {

    }

    public virtual void UpdateState()
    {

    }

    public virtual void ExitState()
    {
        Debug.Log("Player is no longer in:" + this.ToString());
    }

}
