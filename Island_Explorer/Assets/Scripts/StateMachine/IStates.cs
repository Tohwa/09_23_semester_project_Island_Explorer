using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IStates
{
    public void EnterState();

    public void HandleInput();

    public void LogicUpdate();

    public void PhysicsUpdate();

    public void UpdateState();

    public IStates CheckState();

    public void ExitState();
}
