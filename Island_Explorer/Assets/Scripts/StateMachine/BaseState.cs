using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class BaseState
{
    #region Fields
    protected Player player;
    protected Enemy enemy;
    protected NeutralNPC animal;
    protected StateMachine stateMachine;
    protected PlayerData playerData;
    protected NPCData npcData;

    protected float startTime;

    //private string animBoolName;
    #endregion

    public BaseState(Enemy _enemy, StateMachine _stateMachine, NPCData _npcData/*, string _animBoolName */)
    {
        enemy = _enemy;
        stateMachine = _stateMachine;
        npcData = _npcData;
        //animBoolName = _animBoolName;
    }

    public BaseState(NeutralNPC _animal, StateMachine _stateMachine, NPCData _npcData/*, string _animeBoolName */)
    {
        animal = _animal;
        stateMachine = _stateMachine;
        npcData = _npcData;
        //animBoolName = _animBoolName;
    }

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
