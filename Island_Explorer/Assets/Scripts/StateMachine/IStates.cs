using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStates
{
    public void EnterState();

    public void UpdateState();

    public IStates CheckState();

    public void ExitState();
}