using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState : IStates
{
    public virtual void EnterState()
    {

    }
    public virtual IStates CheckState()
    {
        return null;
    }

    public virtual void UpdateState()
    {

    }

    public virtual void ExitState()
    {

    }

}
