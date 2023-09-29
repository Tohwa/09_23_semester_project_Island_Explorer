using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivoreIdleState : BaseState
{
    #region Fields
    private float idleTime = 20f;
    #endregion



    public CarnivoreIdleState(Enemy _enemy, StateMachine _stateMachine, NPCData _npcData) : base(_enemy, _stateMachine, _npcData)
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

        idleTime -= Time.deltaTime;

        if(idleTime <= 0 )
        {
            stateMachine.ChangeEnemyState(enemy.PatrolState);
        }
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
