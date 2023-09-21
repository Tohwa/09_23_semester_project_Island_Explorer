using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class StateMachine
{
    private IStates curPlayerState;

    public void Start()
    {
        curPlayerState = new IdleState();
        curPlayerState.EnterState();
    }

    public void StateUpdate()
    {
        IStates newState;
        newState = curPlayerState.CheckState();

        if (newState != null)
        {
            curPlayerState.ExitState();
            curPlayerState = newState;
            curPlayerState.EnterState();
        }

        curPlayerState.UpdateState();
    }
}
