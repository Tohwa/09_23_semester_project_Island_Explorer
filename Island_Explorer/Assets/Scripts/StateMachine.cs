using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;


public class StateMachine
{
    public BaseState curPlayerState;

    public void Start(BaseState _startState)
    {
        curPlayerState = _startState;
        curPlayerState.EnterState();
    }

    public void ChangeState(BaseState _newState)
    {
        curPlayerState.ExitState();
        curPlayerState = _newState;
        curPlayerState.EnterState();
    }
}
