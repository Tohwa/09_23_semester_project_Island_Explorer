using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class StateMachine
{
    private IStates curState;

    public void Start()
    {
        curState = new IdleState();
        curState.EnterState();
    }

    public void Update()
    {
        IStates newState;
        newState = curState.CheckState();

        if (newState != null)
        {
            curState.ExitState();
            curState = newState;
            curState.EnterState();
        }

        curState.UpdateState();
    }
}
