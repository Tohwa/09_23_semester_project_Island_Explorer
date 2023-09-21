using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    public override void EnterState()
    {
        Console.WriteLine("ICh bin jetzt idle!");
    }

    public override void ExitState()
    {
        Console.WriteLine("Ich Bin JETZT nicht mehr IdLe");
    }

    public override void UpdateState()
    {
        Console.WriteLine("Ich bin idle immer noch?");
    }

    public override IStates CheckState()
    {
        return null;
    }
}
