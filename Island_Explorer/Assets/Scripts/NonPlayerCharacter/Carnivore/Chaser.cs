using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform target;

    private void Update()
    {
        if (target)
        {
            ChaseTarget();
        }
    }

    private void ChaseTarget()
    {
        agent.SetDestination(target.position);
        agent.isStopped = false;
    }
}
