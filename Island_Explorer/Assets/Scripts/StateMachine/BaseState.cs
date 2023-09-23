using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class BaseState
{
    #region Fields
    protected Player player;
    protected StateMachine stateMachine;
    protected PlayerData playerData;

    protected float startTime;

    //private string animBoolName;
    #endregion
    
    public BaseState(Player _player, StateMachine _stateMachine, PlayerData _playerData/*, string _animeBoolName */)
    {
        player = _player;
        stateMachine = _stateMachine;
        playerData = _playerData;
        //animBoolName = _animBoolName;
    }

    public virtual void EnterState()
    {
        Debug.Log("Player has entered a new state!");
        //player.anim.setBool(animBoolName, true);
        startTime = Time.time;
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
        Debug.Log("Player has left its current state.");
        //player.anim.setBool(animBoolName, false);
    }

}
