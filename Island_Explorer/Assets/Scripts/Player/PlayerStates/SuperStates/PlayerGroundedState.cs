using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : BaseState
{
    protected Vector2 input;

    public PlayerGroundedState(Player _player, StateMachine _stateMachine, PlayerData _playerData) : base(_player, _stateMachine, _playerData)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        input = player.InputHandler.MovementInput;
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void UpdateState()
    {
        base.UpdateState();
    }
}
